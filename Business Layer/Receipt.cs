using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace RMS_Project.Business_Layer
{
    internal class Receipt
    {
        public static string HeaderReceipt()

        {
            string header = "";
            // Define receipt header
           return header = "\t\tសង្ក្រានអាយធី-RUPP\n\n" +
                            $"OrderDate: {DateTime.Now.ToString("dd-MMM-yyyy, hh:mm tt")}\n" +
                            "*************************************************************\n" +
                            "\n\t\tCASH RECEIPT\n" +
                            "*************************************************************\n\n";
        }

        
            // Define receipt body
           

    public static string FooterReceipt(Decimal subTotal)
    {
        // Calculate subtotal, tax, and grand total
        decimal subtotal = subTotal;
            decimal tax = 0.00m;
            decimal grandTotalDollar = subtotal + tax;
            int grandTotalRiel = (int)(grandTotalDollar * 4100);

            string footer = "";

            // Define receipt footer
            return footer = "-----------------------------------------------------------------\n" +
                            $"\t\tSubTotal($)\t\t ${subtotal.ToString("F2")}\n" +
                             $"\t\tTax($)\t\t\t ${tax.ToString("F2")}\n\n" +
                            $"\t\tGrandTotalDollar($)\t ${grandTotalDollar.ToString("F2")}\n" +
                            $"\t\tGrandTotalRiel(៛)\t {grandTotalRiel} Riel\n\n\n\n" +
                            "\t-------------THANK YOU-------------\n";

            
        }
    }
}
