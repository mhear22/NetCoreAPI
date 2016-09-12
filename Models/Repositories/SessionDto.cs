using System;

namespace dotapi.Models.Repositories
{
    public class SessionDto : IRow
    {
        public string Id { get; set;}
		public string UserId { get; set; }
		public DateTime Expiry { get; set; }
    }
}