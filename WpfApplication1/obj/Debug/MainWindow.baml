   M S B A M L   `   `   `  ����C  ?Grind.FM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:WpfApplication1     5   	   -   5          � Title$  Lulu desktop helper��5   	   $	��200��6%   $	��211��62    � AllowsTransparency .  � WindowStyle$
 None=�6X   
������  � Icon$ ./Resources/favicon.ico��5   	   .��5	      � .+�5
   
   (   "WpfApplication1.AnimatedGIFControl  -   5          Name$ GIFCtrl��5
   #   $��41,25,20,25q�64    � ToolTip$> 8Click = Settings. DoubleClick = Close. RightClick = Mute��6I   �� 5   
   -   5         ��Name$ VolumeSlider��5      $
��Left=�6'   $��	12,69,0,0q�6B   $	��Top=�6U   $��24��6m    �� Orientation$ Vertical=�6x   $	��106��6�    � Maximum$ 1Q�6�   	 � Value$		 0.1Q�6�   $y�Hidden=�6�   �� 5   
   -   5        
 ��Name$
 ChangeImage��5      $	��GIF��6&   $
��Left=�64   $��	14,44,0,0q�6O   $	��Top=�6b   $��20��6z   $��8(�6�   $��20��6�    J� RenderTransformOrigin$ 0.45,0.5&�6�   $
��Bold"�6�   $y�Hidden=�6�   �� 5   
   -   5        $
 RadiostantionButton��5      $��FM��6.   $
��Left=�6;   $��	14,19,0,0q�6V   $	��Top=�6i   $��20��6�   $��20��6�   $��8(�6�   $
��Bold"�6�   $y�Hidden=�6�   5      5      