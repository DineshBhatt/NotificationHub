using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationhubDAL.Repository
{
    public class NotificationHubHomePageRepository
    {
        public string EventName;
        public int EventId;
        public string userid;
        public string ChannelsSelected ;
        public bool Subscription;
        
    }
    public class NotificationHubApprovalRepository
    {
        public string TemplateName;
        public string operationalManagerName;
        public string OperationManagerId;
    }
    public class Channels
    {
        public string ChannelName;
        public int channelId;
    }
}
