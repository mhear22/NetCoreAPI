using System;

namespace CoreApp.Models.Repositories
{
    public class SessionDto : IRow
    {
        public string Id { get; set;}
		public string UserId { get; set; }
		public DateTime SetTime { get; set; }
    }
}