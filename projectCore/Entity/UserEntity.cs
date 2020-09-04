using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectCore.Entity
{
    public class UserEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }

        public IDictionary<string, object> toDictionary()
        {
            IDictionary<string, object> user = new Dictionary<string, object>();
            user.Add("id", this.id);
            user.Add("name", this.name);
            user.Add("last_name", this.last_name);

            return user;
        }
    }
}
