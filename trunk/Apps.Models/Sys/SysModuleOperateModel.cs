﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2012-12-25 17:15:28 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

namespace Apps.Models.Sys
{

    public partial class SysModuleOperateModel
    {
        [Display(Name = "ID")]
        public override string Id { get; set; }
        [Display(Name = "操作名称")]
        public override string Name { get; set; }
        [Display(Name = "操作码")]
        public override string KeyCode { get; set; }
        [Display(Name = "所属模块")]
        public override string ModuleId { get; set; }
        [Display(Name = "是否验证")]
        public override bool IsValid { get; set; }
        [Required(ErrorMessage = "{0}必须填写")]
        [IsNumberExpression]//如果填写判断是否是数字
        [Display(Name = "排序号")]
        public override int Sort { get; set; }


    }
}

