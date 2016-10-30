using Umbraco.Web;


namespace ModelsBuilderified.Models
{
    public partial class UmbMaster : INavigationContent
    {
        public bool IsVisible
        {
            get { return this.IsVisible(); }
        }

        bool INavigationContent.IsActive
        {
            get { return UmbracoContext.Current.PageId == Id; }
        }

        string INavigationContent.Target
        {
            get { return Url.StartsWith("/") ? "_top" : "_blank"; }
        }
    }
}