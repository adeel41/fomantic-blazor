﻿namespace Fomantic.Blazor.UI.Features
{
    class FomanticComponentWithSizeFeature : UIFeatureDefinition<IFomanticComponentWithSize>
    {
        /// <summary>   Determine if the component should be mini. </summary>
        const string MiniClass = "mini";
        /// <summary>   Determine if the component should be tiny. </summary>
        const string TinyClass = "tiny";
        /// <summary>   Determine if the component should be small. </summary>
        const string SmallClass = "small";
        /// <summary>   Determine if the component should be medium. </summary>
        const string MediumClass = "";
        /// <summary>   Determine if the component should be large. </summary>
        const string LargeClass = "large";
        /// <summary>   Determine if the component should be big. </summary>
        const string BigClass = "big";
        /// <summary>   Determine if the component should be huge. </summary>
        const string HugeClass = "huge";
        /// <summary>   Determine if the component should be massive. </summary>
        const string MassiveClass = "massive";

        public override string ProvideCssClass(IFomanticComponentWithSize component)
        {
            return ToClass(component.Size);
        }


        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Convert <see cref="Fomantic.Blazor.UI.Size"/> to given class. </summary>
        ///
        /// <param name="size"> Size Value. </param>
        ///
        /// <returns>   Given class from <paramref name="size"/> </returns>
        ///-------------------------------------------------------------------------------------------------

        public static string ToClass(Size size)
        {
            return size switch
            {
                Size.Mini => MiniClass,
                Size.Tiny => TinyClass,
                Size.Small => SmallClass,
                Size.Medium => MediumClass,
                Size.Large => LargeClass,
                Size.Big => BigClass,
                Size.Huge => HugeClass,
                Size.Massive => MassiveClass,
                _ => string.Empty,
            };
        }
    }

}
