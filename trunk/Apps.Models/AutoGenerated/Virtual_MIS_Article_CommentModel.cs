//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.MIS
{
	public class Virtual_MIS_Article_CommentModel
	{
			public virtual string Id { get; set; }
			public virtual string ArticleId { get; set; }
			public virtual string UserId { get; set; }
			public virtual string TrueName { get; set; }
			public virtual string IP { get; set; }
			public virtual string BodyContent { get; set; }
			public virtual Nullable<System.DateTime> CreateTime { get; set; }
			public virtual Nullable<int> IsReply { get; set; }
			public virtual string ReplyContent { get; set; }
			public virtual Nullable<System.DateTime> ReplyTime { get; set; }
		}
}