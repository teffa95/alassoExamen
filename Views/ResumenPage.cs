
namespace alassoExamen.Views
{
    internal class ResumenPage : Page
    {
        private string text1;
        private string text2;
        private string text3;
        private object date;
        private string? v1;
        private string? v2;
        private string text4;
        private object text5;

        public ResumenPage(string text1, string text2, string text3, object date, string? v1, string? v2, string text4, object text5)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.date = date;
            this.v1 = v1;
            this.v2 = v2;
            this.text4 = text4;
            this.text5 = text5;
        }
    }
}