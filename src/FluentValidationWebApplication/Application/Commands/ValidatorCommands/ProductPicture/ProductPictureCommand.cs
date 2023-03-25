namespace FluentValidationWebApplication.Application.Commands.ValidatorCommands.ProductPicture
{
    public class ProductPictureCommand
    {
        public List<Picture> Pictures { get; set; }
    }

    public class Picture
    {
        public int ProductPictureId { get; set; }

        public string Path { get; set; }
    }
}
