using System.ComponentModel.DataAnnotations;

namespace GenerateBarCodeDotNet6.Models
{
    public class GenerateBarcodeModel
    {

        [Display(Name = "Enter Barcode Text")]
        public string BarcodeText
        {
            get;
            set;
        }
    }
}
