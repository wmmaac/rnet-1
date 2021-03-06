﻿using System.IO;
using System.IO.Ports;

namespace Rnet
{

    /// <summary>
    /// Provides access to RNet through a serial port.
    /// </summary>
    public sealed class RnetSerialPortConnection : RnetConnection
    {

        SerialPort port;

        /// <summary>
        /// Initializes a new connection to an RNET device by serial port.
        /// </summary>
        /// <param name="port"></param>
        public RnetSerialPortConnection(string port)
        {
            this.port = new SerialPort(port, 19200, Parity.None, 8, StopBits.One);
        }

        internal override Stream Stream
        {
            get { return port.BaseStream; }
        }

        public override bool IsOpen
        {
            get { return port.IsOpen; }
        }

        public override void Open()
        {
            port.Open();
        }

        public override void Close()
        {
            Dispose();
        }

        public override void Dispose()
        {
            if (port != null)
            {
                port.Dispose();
                port = null;
            }
        }

    }

}
