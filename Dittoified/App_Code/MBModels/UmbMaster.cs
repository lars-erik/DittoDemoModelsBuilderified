using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{
    /// <summary>
    /// Summary description for UmbMaster
    /// </summary>
    public partial class UmbMaster
    {
        private UmbHomePage home;

        public UmbHomePage Home
        {
            get
            {
                if (home == null)
                    home = this.AncestorOrSelf<UmbHomePage>();
                return home;
            }
        }
    }

}