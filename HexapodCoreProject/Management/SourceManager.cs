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
        private IMoveSource _selectSource;

        public SourceManager()
        {
            moveSources = new List<IMoveSource>();
        }

        public void addMoveSource(IMoveSource source)
        {
            moveSources.Add(source);
        }

        public List<IMoveSource> getSources()
        {
            return moveSources;
        }

        public bool selectSource(string sourceName)
        {
            foreach(var source in moveSources)
            {
                if(source.getName() == sourceName)
                {
                    if (_selectSource !=null)
                        _selectSource.Terminate();
                    _selectSource = source;
                    _selectSource.Run();
                    return true;
                }
            }
            return false;
        }

        public void TerminateSource()
        {
            if(_selectSource != null)
                _selectSource.Terminate();
        }

        public void RunSource()
        {
            if (_selectSource != null)
                _selectSource.Run();
        }
    }
}
