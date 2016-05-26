using System;

namespace WebApplication1
{
    internal class ConnectionSettings
    {
        private Uri node;
        private string v;

        public ConnectionSettings(Uri node, string v)
        {
            this.node = node;
            this.v = v;
        }
    }
}