﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:2.0.50727.42
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapeOpenSplitter {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Mose.CapeOpenToolkit.UnitProxy;
    using System.Runtime.InteropServices;
    
    
    [System.Runtime.InteropServices.GuidAttribute("14560354-d48e-433b-9920-0ab41ae90105")]
    public partial class SplitterUnit {
        
        public SplitterUnit() : 
                base() {
        }
        
        public double SplitFractionValue {
            get {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("SplitFraction")));
                return zParam.Value;
            }
            set {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("SplitFraction")));
                zParam.Value = value;
            }
        }
        
        public Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject InputPort {
            get {
                Mose.CapeOpenToolkit.UnitProxy.MaterialPort zPort;
                zPort = ((Mose.CapeOpenToolkit.UnitProxy.MaterialPort)(Ports.GetPortByName("InputPort")));
                return ((Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject)(zPort.ConnectedObject));
            }
        }
        
        public Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject OutputPort1 {
            get {
                Mose.CapeOpenToolkit.UnitProxy.MaterialPort zPort;
                zPort = ((Mose.CapeOpenToolkit.UnitProxy.MaterialPort)(Ports.GetPortByName("OutputPort1")));
                return ((Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject)(zPort.ConnectedObject));
            }
        }
        
        public Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject OutputPort2 {
            get {
                Mose.CapeOpenToolkit.UnitProxy.MaterialPort zPort;
                zPort = ((Mose.CapeOpenToolkit.UnitProxy.MaterialPort)(Ports.GetPortByName("OutputPort2")));
                return ((Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject)(zPort.ConnectedObject));
            }
        }
        
        protected override void OnInitialize() {
            Name = "SplitterUnit";
            Description = "Splitter Unit .Net";
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "InputPort", "Input Port of Splitter", CapeOpenPortDirection.Inlet));
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "OutputPort1", "Output Port 1 of Splitter", CapeOpenPortDirection.Outlet));
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "OutputPort2", "Output Port 2 of Splitter", CapeOpenPortDirection.Outlet));
            Parameters.Add(DoubleParameter.Create("SplitFraction", "Split Fraction of Splitter", CapeOpenParameterMode.ReadWrite, -1E+35, 1E+35, 0.5));
        }
    }
}