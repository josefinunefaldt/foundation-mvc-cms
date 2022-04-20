
   using EPiServer;
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Shell.ObjectEditing;
    using EPiServer.Web;
    using Foundation.Features.Shared; 
    using Foundation.Infrastructure;
    using System.ComponentModel.DataAnnotations;
    using Foundation.Features.Shared;

namespace Foundation.Features.Blocks.ImageBlock

    {
        [ContentType(DisplayName = "Image Block",// vad mitt imageblock
          GUID = "94a7b4be-5345-4ac2-800b-8372370a1691",//  måste vara unikt guid
          Description = "Image block with overlay for text",
         GroupName = GroupNames.Content)]
        [ImageUrl("/icons/cms/blocks/CMS-icon-block-22.png")]
        public class ImageBlock : FoundationBlockData
    {

      
        [CultureSpecific]
        [Display(Name = "Text", Order = 10)] // vilken ordning det kommer, 10 först, sedan 20 osv... iställlet för 1,2 osv
        public virtual XhtmlString Text { get; set; }//textruta med egenskaper

        [UIHint(UIHint.Image)]
        [Display(Name = "Image", Order = 20)]
        public virtual ContentReference Image { get; set; }

        [UIHint(UIHint.Video)]
        [Display(Name = "MyVideo", Order = 20)]
        public virtual ContentReference MyVideo { get; set; }

        [CultureSpecific]// viktigt om man har text på svenska och engelska
        [Display(Name = "Text2", Order = 30)]
        public virtual string Text2 { get; set; }// textruta utan egenskaper

        [UIHint(UIHint.Textarea)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "* Text must be between 3 and 50 character in length.")]
        [CultureSpecific]// viktigt om man har text på svenska och engelska
        [Display(Name = "Text3", Order = 30)]   
        public virtual string Text3 { get; set; }// textruta utan egenskaper

        [Display(Name = "Numbers", Order = 40)]
        public virtual int Numbers { get; set; }//nummerruta (int)

        [Display(Name = "Numbers2", Order = 50)]
        public virtual double Numbers2 { get; set; }//nummerruta (double)

      
        [Display(Name = "MyBool", Order = 60)]
        public virtual bool MyBool { get; set; }//bool

        [CultureSpecific]
        [Display(Name = "Datum", Order = 70)]
        public virtual System.DateTime Datum  { get; set; }//datum

    }
}
