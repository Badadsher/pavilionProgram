   M S B A M L   `   `   `  ����F  BPavilionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PavilionApp.ViewPavilionApp.View  5      !    PavilionApp.View.CapchaPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PavilionApp.View     5        N� Title$  
CapchaPage��5	       � 	Resources 5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	     7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $	 border��6!   #��z��61   $
 15��6[   #��z��6m   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      �� 5B   
   $ 	#FFABAdB3��68   �� 5C   
   $ 	#FF7EB4EA��6;   �� 5D   
   $ 	#FF569DE5��67   �� 5E   
   " ��6&   .�5F      ��  � ��# � ��6+   �� 5G       � ��8   6,   �� 5H       � ��# � ��6+   �� 5I       � ��$ 1q�60   �� 5J       �@ TabNavigation$
 None=�6A   �� 5K       � ��$
 Left=�6;   �� 5L       �@�FocusVisualStyle 61   Z� �� 5M       �@J�	AllowDrop . 6*   �� 5N       �@��PanningMode$ VerticalFirst=�69   �� 5O       �@��IsFlicksEnabled .  67   �� 5P       � �� 5Q      �� 5R      " ��6&   .R�5S      �� $	 border��6!   #��z��61   $
 15��6[   #��z��6m   #��z��6�    . ._�5T      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5U       5V      P� 5W       � {� .  . �5X   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5Y      P� 5Z       �@J�IsMouseOver . . �5[   "   �� $ border��6@   8   � ��6T   5\      P� 5]       �@J�IsKeyboardFocused . . �5^   "   �� $ border��6@   8   � ��6T   5_      5a      5c       5d      ]� 5e       5f      �� 5g      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5h       �@��IsSelectionActive .  6A   ./�5j      ��  �@��SelectionBrush# � /�67   5k      5m      5n      .��5p      � 
�������.+�5s   
   �� $
��Left=�6   $��64��6/   $��	728,0,0,0q�6;   $	��Top=�6N   $��62��6f   ��5t      �� 5u       �� ImageSource$ /Images/logo.jpg��6   5w      �� 5x   
   $��Center=�6   $��0,64,0,0q�61   $
��Wrap=�6C   $f��`ВЫ МНОГО РАЗ НЕПРАВИЛЬНО ВВЕЛИ ПАРОЛЬ,ВВЕДИТЕ КАПЧУ!��6W   $	��Top=�6�   $��Arial)�6�   $��14(�6�   $
��Bold"�6�   ���	#FF78909C6�   �� 5y   
   -   5         ��Name$ inputCapcha��5y      #���  6'   $��Center=�6O   $��	0,215,0,0q�6l    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��268��6�   $��57��6�   $��Center=�6�   $��Center=�6�   �� 5z   
   -   5         ��Name$ verifyCapcha��5z      #��� 
 6'   $��ПРОВЕРИТЬ��6N   $��Center=�6b   $��	0,299,0,0q�6   $	��Top=�6�   $��44��6�   $	��128��6�   
�������
����������	#FBFF9C1A6   �� 5{   
   -   5         ��Name$ 
capchaText��5{      $��Center=�6(   $��	0,162,0,0q�6E   $
��Wrap=�6X   $�� ��6l   $	��Top=�6t   $��27��6�   $	��268��6�    �� TextAlignment$ Center=�6�   $��14(�6�   $��Arial)�6�   ���	#FF37474F6�   5|      5}      