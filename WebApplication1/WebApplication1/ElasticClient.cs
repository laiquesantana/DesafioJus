namespace WebApplication1
{
    internal class ElasticClient
    {
        private ConnectionSettings settings;

        public ElasticClient(ConnectionSettings settings)
        {
            this.settings = settings;
        }
    }
}