﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Factory
{
    public class MT : NotiInterface
    {

        public string NotiType()
        {
            var qu = @"SELECT [NotificationId],[Status],[Message],[ExtraColumn] FROM [dbo].[tbl_Notification]  where  ExtraColumn='MD' and ExtraColumn='MTL'";

            return Models.NotificaionService.GetNotification(qu);
        }
    }
}