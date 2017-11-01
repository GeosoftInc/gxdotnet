using System;

using GeoEngine.Core.GXNet;
using Geosoft.Desktop.GXNet;

using CoreConstant = GeoEngine.Core.GXNet.Constant;

namespace chanadd
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class ChannelAdd
   {

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         CGX_NET pGeo = null;
         CDB hDB = null;
         CVV hVV = null;
         CVM hVM = null;
         CVA hVA = null;

         Int32 iChan, iLine; // database symbols

         int iVA, iL, iLines, iS;
         double dValue;
         DoubleVector dData;


         // --- Usage ---
         if (args.Length < 3)
         {
            Console.WriteLine("Usage: chanadd database channel value");
            return;
         }

         try
         {
            // --- Initialize ---
            pGeo = new CGX_NET("CHANADD", "V1", 2047, null, 0);
            if (pGeo == null)
            {
               Console.WriteLine("Unable to start Geosoft session");
               return;
            }

            // ---
            // Open a database.
            // Note that all databases created by normal Geosoft users will have
            // user name "SUPER" with password "".  Third-party or custom applications
            // may create databases that require a user-name and password, in which
            // case you require these values to open the database.
            // ---
            hDB = CDB.Open(args[0], "SUPER", "");

            // --- Get the channel handle ---
            iChan = hDB.FindSymb(args[1], CoreConstant.DB_SYMB_CHAN);
            if (iChan == CoreConstant.NULLSYMB)
            {
               Console.WriteLine(args[1] + " channel not found in database " + args[0]);
               return;
            }

            // --- Lock channel for read-writer ---
            hDB.LockSymb(iChan, CoreConstant.DB_LOCK_READWRITE, CoreConstant.DB_WAIT_NONE);

            // --- do we need a VV or a VA? ---
            iVA = hDB.iGetColVA(iChan); // number of elements in a VA, 1 if its a VV
            if (iVA == 1)
            {
               // --- Create a VV to hold data array ---
               hVV = CVV.CreateExt(CoreConstant.GS_DOUBLE, 0);
            }
            else
            {
               // --- its a VA channel ---
               hVA = CVA.CreateExt(CoreConstant.GS_DOUBLE, 0, iVA);
            }

            // --- Get a real VM to hold the data in memory ---
            hVM = CVM.Create(CoreConstant.GS_REAL, 0);

            // -- Get Value to add to data ---
            dValue = Convert.ToDouble(args[2]);

            // --- Count selected lines ---
            iLines = hDB.iCountSelLines();

            // --- Go through all selected lines ---
            iL = 0;
            iLine = hDB.FirstSelLine();

            do
            {

               // --- Break if line is not a valid line ---
               if (hDB.iIsLineValid(iLine) == 0) break;

               // --- Update progress ---
               Console.WriteLine("Chanadd " + (iL + 1) + " of " + iLines + " Complete");

               // --- Read Data ---
               if (iVA == 1)
               {

                  // --- get VV data ---
                  hDB.GetChanVV(iLine, iChan, hVV);
               }
               else
               {

                  // --- get VA data ---
                  hDB.GetChanVA(iLine, iChan, hVA);

                  // ---
                  // Get the VV to the VA data.  This VV contains all VA data
                  // by element, then by row.  The VV is owned by the VA, so you
                  // cannot destroy the VA or the VV will become invalid.
                  // ---

                  hVV = hVA.GetFullVV();
               }

               // ---
               // Get data VM from the VV.  This will re-size the VM to
               // hold all the data in the VV.
               // ---

               CVV.CopyVVtoVM(hVM, hVV);

               // --- now get a pointer to the data ---

               iS = hVV.iLength();

               dData = CGX_NET.GetDoubleVM(hVM, iS);

               //-----------------------------------------------------------------------
               //                             MAIN MATH CODE
               //-----------------------------------------------------------------------

               for (int i = 0; i < iS; i++)
               {
                  dData[i] += dValue;
               }

               // --- Put the VM data back in the VV ---
               hVV.CopyVMtoVV(hVM);

               // --- Write data back to the database ---
               if (iVA == 1)
               {

                  hDB.PutChanVV(iLine, iChan, hVV);
               }
               else
               {
                  // ---
                  // Since the VA owned the VV, changing the VV data is the same as
                  // changing toe VA data.  All I need to do is write the VA data.
                  // ---
                  hDB.PutChanVA(iLine, iChan, hVA);
               }

               // --- Advance to Next Line ---
               iLine = hDB.NextSelLine(iLine);
               iL++;
            }
            while (true);

            Console.WriteLine("ChanAdd Complete");


            // --- Cleanup ---

            hDB.UnLockSymb(iChan);

            // ---
            // Destroy any handles that were created.  This is not really necessary since
            // destroying a pGeo handle will destroy all classes.  However, we considere it
            // good practice to destroy your own instances since it ensures you are
            // thinking about what instances you have created.  You really do not want to
            // keep class instances longer than you need them since they consume system
            // resources that could be better used by other parts of your application.
            // ---

            if (hVM != null) hVM.Dispose();

            // --- be careful not to try to destroy a VV owned by a VA ---

            if (hVV != null && (iVA != 1)) hVV.Dispose();

            if (hVA != null) hVA.Dispose();

            hDB.Dispose();
         }
         catch (CERROR e)
         {
            Console.WriteLine("Error: " + e.Message);
         }
         catch (Exception ex)
         {
            Console.WriteLine("Error: " + ex.Message);
         }
         finally
         {
            if (pGeo != null)
               pGeo.Dispose();
         }
      }
   }
}
