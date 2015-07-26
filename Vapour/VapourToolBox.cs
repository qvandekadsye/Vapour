using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vapour
{
    public sealed class VapourToolBox
    {
        
        private static readonly VapourToolBox toolBox = new VapourToolBox();
        private VapourToolBox()
        {
            
        }
        

        public static VapourToolBox getToolBox
        {
            get
            {
                return toolBox;
            }
        }

       

        public void checkSystemRequirement(String gameID)
        {
            
            Process.Start("steam://checksysreqs/" + gameID);
        }

        public void openBackup(String gameID)
        {
            Process.Start("steam://backup/" + gameID);
            
        }

        public void install(String gameID)
        {
            Process.Start("steam://install/" + gameID);
            
        }

        public void verifyFiles(String gameID)

        {
            Process.Start("steam://validate/" + gameID);
            
        }

        public dynamic getSteamID(String URL)
        {
            try
            {
                String gameID = URL.Substring("http://store.steampowered.com/app/".Length, URL.Length - "http://store.steampowered.com/app/".Length - 1);
                int a = int.Parse(gameID);
                return gameID;
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
