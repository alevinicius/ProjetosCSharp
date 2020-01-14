using System.Globalization;
using System.Text;

namespace Ex01.Entities
{
    class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("\nTotal Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
