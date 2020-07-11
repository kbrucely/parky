using ParkyWeb.Models;
using ParkyWeb.Respository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParkyWeb.Respository
{
        public class TrailRepository : Repository<Trail>, iTrailRepository
        {
            private readonly IHttpClientFactory _clientFactory;

            public TrailRepository(IHttpClientFactory clientFactory) : base(clientFactory)
            {
                _clientFactory = clientFactory;
            }
        }
}
