﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodInterfacesProject;
using HexapodCoreProject.Interfaces;
using HexapodCoreProject.Management;
using HexapodCoreProject.Masters;

namespace HexapodCoreProject
{
    public class HexapodInstance
    {
        private Storage _storage;
        private Hexapod _hexapod;
        private SourceManager _sourceManager;
        private LogMaster _logMaster;
        private PacketMaster _packetMaster;
        private SerialPortMaster _serialPortmaster;

        public HexapodInstance(string fileName)
        {
            CreateInstances(fileName);
        }

        public void CreateInstances(string fileName)
        {
            _storage = new Storage();
            //_storage.SaveFile(fileName);
            _storage.OpenFile(fileName);

            _logMaster = new LogMaster();
            _serialPortmaster = new SerialPortMaster();
            _packetMaster = new PacketMaster(_serialPortmaster);
            _sourceManager = new SourceManager();
            _hexapod = new Hexapod(_storage, _packetMaster);
        }

        public void addMoveSource(IMoveSource moveSource)
        {
            _sourceManager.addMoveSource(moveSource);
        }
    }
}