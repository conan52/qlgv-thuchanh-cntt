using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace TKBThucHanh.Views
{
    public static class MvcUlts
    {
        public static MvcHtmlString DisplayEnumFor<TModel, TResult>(this HtmlHelper<TModel> helper,
        Expression<Func<TModel, TResult>> expression) where TResult : struct
        {
            var value = expression.Compile().Invoke(helper.ViewData.Model);
            var propName = ExpressionHelper.GetExpressionText(expression);

            var description = typeof(TResult).GetMember(value.ToString())[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), true).FirstOrDefault();
            return MvcHtmlString.Create(description != null ? ((DescriptionAttribute) description).Description : value.ToString());
        }
    }
}