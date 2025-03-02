using Maui.FreakyControls.Shared.Enums;
using System.Windows.Input;

namespace Maui.FreakyControls;

public class FreakyTimePicker : TimePicker, IDrawableImageView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(
             nameof(Image),
             typeof(ImageSource),
             typeof(FreakyDatePicker),
             default(ImageSource));

    public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(
           nameof(ImageHeight),
           typeof(int),
           typeof(FreakyDatePicker),
           25);

    public static readonly BindableProperty ImageWidthProperty = BindableProperty.Create(
           nameof(ImageWidth),
           typeof(int),
           typeof(FreakyDatePicker),
           25);

    public static readonly BindableProperty ImageAlignmentProperty = BindableProperty.Create(
           nameof(ImageAlignment),
           typeof(ImageAlignment),
           typeof(FreakyDatePicker),
           ImageAlignment.Right);

    public static readonly BindableProperty ImagePaddingProperty = BindableProperty.Create(
           nameof(ImagePadding),
           typeof(int),
           typeof(FreakyDatePicker),
           5);

    public static readonly BindableProperty ImageCommandProperty = BindableProperty.Create(
          nameof(ImagePadding),
          typeof(ICommand),
          typeof(FreakyDatePicker),
          default(ICommand));

    public static readonly BindableProperty ImageCommandParameterProperty = BindableProperty.Create(
          nameof(ImageCommandParameter),
          typeof(object),
          typeof(FreakyDatePicker),
          default(object));

    /// <summary>
    /// Command parameter for your Image tap command
    /// </summary>
    public object ImageCommandParameter
    {
        get => GetValue(ImageCommandParameterProperty);
        set => SetValue(ImageCommandParameterProperty, value);
    }

    /// <summary>
    /// A command that you can use to bind with your Image that you added to your Entry's ViewPort
    /// </summary>
    public ICommand ImageCommand
    {
        get => (ICommand)GetValue(ImageCommandProperty);
        set => SetValue(ImageCommandProperty, value);
    }

    /// <summary>
    /// Padding of the Image that you added to the ViewPort
    /// </summary>
    public int ImagePadding
    {
        get => (int)GetValue(ImagePaddingProperty);
        set => SetValue(ImagePaddingProperty, value);
    }

    /// <summary>
    /// Width of the Image in your ViewPort
    /// </summary>
    public int ImageWidth
    {
        get => (int)GetValue(ImageWidthProperty);
        set => SetValue(ImageWidthProperty, value);
    }

    /// <summary>
    /// Height of the Image in your ViewPort
    /// </summary>
    public int ImageHeight
    {
        get => (int)GetValue(ImageHeightProperty);
        set => SetValue(ImageHeightProperty, value);
    }

    /// <summary>
    /// An <see cref="ImageSource"/> that you want to add to your ViewPort
    /// </summary>
    public ImageSource ImageSource
    {
        get => (ImageSource)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

    /// <summary>
    /// <see cref="ImageAlignment"/> for your Image's ViewPort, By default set to Right.
    /// </summary>
    public ImageAlignment ImageAlignment
    {
        get => (ImageAlignment)GetValue(ImageAlignmentProperty);
        set => SetValue(ImageAlignmentProperty, value);
    }
}