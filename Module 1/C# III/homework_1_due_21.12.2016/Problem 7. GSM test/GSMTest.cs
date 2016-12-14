using System.Text;

namespace Problem_7
{
    /// <summary>
    /// Provides testing functionality for the <see cref="GSM"/> class.
    /// </summary>
    static public class GSMTest
    {
        /// <summary>
        /// Creates a sample array of stock instances of <see cref="GSM"/> objects.
        /// </summary>
        /// <returns><see cref="System.Array"/> of <see cref="GSM"/> instances</returns>
        public static GSM[] CreateGSMArray()
        {
            return new GSM[]
            {
                new GSM(),
                new GSM("Basic GSM", "Basic manufacturer"),
                new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
                            new Battery("Custom battery", 26.45698M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon),
                            new Display("Custom display", 64000)),
            };
        }

        /// <summary>
        /// Returns information about the iPhone-4S model as <see cref="string"/>
        /// </summary>
        /// <returns>a multi-line <see cref="string"/></returns>
        public static string DisplayStaticIPhone4
        {
            get
            {
                return new StringBuilder()
                    .AppendFormat(" {0} {1}\r\n", "Model          ", GSM.IPhone4s.Model)
                    .AppendFormat(" {0} {1}\r\n", "Manufacturer   ", GSM.IPhone4s.Manufacturer)
                    .AppendFormat(" {0} {1:C2}\r\n", "Price          ", GSM.IPhone4s.Price)
                    .AppendFormat(" {0} {1}\r\n", " Display size   ", GSM.IPhone4s.Display.Size)
                    .AppendFormat(" {0} {1:N0}\r\n", " Colors         ", GSM.IPhone4s.Display.NumberOfColors)
                    .AppendFormat(" {0} {1}\r\n", " Battery model  ", GSM.IPhone4s.Battery.Model)
                    .AppendFormat(" {0} {1}\r\n", " Battery type   ", GSM.IPhone4s.Battery.BatteryType)
                    .ToString();
            }
        }
    }
}
