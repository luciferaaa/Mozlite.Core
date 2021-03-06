﻿using System;

namespace Mozlite.Mvc.TagHelpers.Templates
{
    /// <summary>
    /// Foreach语句。
    /// </summary>
    public class ForeachTemplateSyntaxExecutor : ITemplateSyntaxExecutor
    {
        /// <summary>
        /// 关键词。
        /// </summary>
        public string Keyword => "foreach";

        /// <summary>
        /// 通过当前对象执行语法所得到的字符串。
        /// </summary>
        /// <param name="element">属性实例对象。</param>
        /// <param name="executor">解析器接口。</param>
        /// <param name="instance">当前实例对象。</param>
        /// <param name="func">获取当前对象属性值的方法。</param>
        /// <returns>返回脚本代码</returns>
        public string End(TemplateSyntaxElement element, ITemplateExecutor executor, object instance, Func<object, string, object> func)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 通过当前对象执行语法所得到的字符串。
        /// </summary>
        /// <param name="element">属性实例对象。</param>
        /// <param name="executor">解析器接口。</param>
        /// <returns>返回脚本代码</returns>
        public string Begin(TemplateSyntaxElement element, ITemplateExecutor executor)
        {
            var items = element.Args.Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length == 3 && items[1] == "in")
                return $"{items[2]}.forEach(function({items[0]},index){{";
            throw new Exception("语法错误，必须为{{foreach xx in xxs}}!");
        }

        /// <summary>
        /// 通过当前对象执行语法所得到的字符串。
        /// </summary>
        /// <param name="element">属性实例对象。</param>
        /// <param name="executor">解析器接口。</param>
        /// <param name="instance">当前实例对象。</param>
        /// <param name="func">获取当前对象属性值的方法。</param>
        /// <returns>返回脚本代码</returns>
        public string Begin(TemplateSyntaxElement element, ITemplateExecutor executor, object instance, Func<object, string, object> func)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 通过当前对象执行语法所得到的字符串。
        /// </summary>
        /// <param name="element">属性实例对象。</param>
        /// <param name="executor">解析器接口。</param>
        /// <returns>返回脚本代码</returns>
        public string End(TemplateSyntaxElement element, ITemplateExecutor executor)
        {
            return "});";
        }
    }
}