   M S B A M L   `   `   `  ????  	Paint_Wpf    Paint_Wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     ? Title$  
MainWindow??5   	   $	??900??6   $
??1500??6)    ? 	Resources 5      ?? 5   
      KeyMyEditingModes   ?? Type2  ,System.Windows.Controls.InkCanvasEditingMode"  6)   .s?5      ??  ?? Member$ InkCanvasEditingMode.Ink??6   ?? 5	      $! InkCanvasEditingMode.Select??6   ?? 5
      $' !InkCanvasEditingMode.EraseByPoint??6   ?? 5      $( "InkCanvasEditingMode.EraseByStroke??6   5      ?? 5   
   MyDrawingAttributes  *  $System.Windows.Ink.DrawingAttributes"  6.   .s?5           Color$ Black??6      5      $
 Pink??6      5      $ Purple??6      5      $ Yellow??6      5      $	 Red??6      5      $ 
LightGreen??6      5      $
 Blue??6      5      $ 
LightCoral??6      5      $ 	LightBlue??6    5      .??5      ?? -   5         ??Name$ 
DrawingAtr??5      .+?5   
   ?? -   5        $??DrawwingAttr??5   .   $
??1500??6   $	??500??6!    ?? EditingMode 5      ??  ?? ElementName$ lbEditingModes?? ?? Path$ SelectedValue?	 ?? DefaultDrawingAttributes	 5        5      
   Height$
 10Q?6_      Width$ 10Q?6k    6$   ?? $ lbColors??$ SelectedValue?6k   5      ?? 5    
   -   5         ??Name$ lbEditingModes??5         MyEditingModes#??[ 6*   ?? 5!   
   -   5        $ lbColors??5!        MyDrawingAttributes#??[ 6$   ??5"      ?? 5#      .R?5$      ?? ??6    ?? $ SelectedValue???6J   ?? $ Color?6h   5%      5'      ?? 5(   
   -   5        $??slider??5(      $??0, 10, 0, 0q?6   $??50??64   $	??500??6@    ? Minimum$ 1Q?6L    ? Maximum$	 100Q?6X    ? Value$ 20Q?6f   6q   5)      5*      