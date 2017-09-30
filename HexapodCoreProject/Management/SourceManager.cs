using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Interfaces;
using HexapodInterfacesProject;

namespace HexapodCoreProject.Management
{
    public class SourceManager
    {
        private List<IMoveSource> moveSources;

        public SourceManager()
        {
            moveSources = new List<IMoveSource>();
        }

        public void addMoveSource(IMoveSource source)
        {
            moveSources.Add(source);
        }
    }
}
