//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Commerce.DemoStore.Models
{
	// Mixin Content Type with alias "productGroupComp"
	/// <summary>Product Group</summary>
	public partial interface IProductGroupComp : IPublishedContent
	{
		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		string Description { get; }

		/// <summary>Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent Image { get; }
	}

	/// <summary>Product Group</summary>
	[PublishedModel("productGroupComp")]
	public partial class ProductGroupComp : PublishedContentModel, IProductGroupComp
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const string ModelTypeAlias = "productGroupComp";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProductGroupComp, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProductGroupComp(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Description: A short description for this item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("description")]
		public virtual string Description => GetDescription(this, _publishedValueFallback);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static string GetDescription(IProductGroupComp that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "description");

		///<summary>
		/// Image: An image for this item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("image")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent Image => GetImage(this, _publishedValueFallback);

		/// <summary>Static getter for Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent GetImage(IProductGroupComp that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(publishedValueFallback, "image");
	}
}