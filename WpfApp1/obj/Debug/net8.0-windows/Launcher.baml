   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Launcher   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Launcher��5   	   $	��700��6   $
��1100��6'    � WindowStartupLocation$ CenterScreen=�64   $	��700��6Y   $
��1100��6i    � 
ResizeMode$ NoResize=�6y   ���#2A1B3D � WindowStyle$
 None=�5	       � 	Resources 5
         TopMenuButton �� 
TargetType �� 
TargetType �� Property �� Value	 �� Triggers
 �� Binding �� Path �� ElementName �� Value �� RelativeSource �� Mode �� AncestorType-  'System.Windows.Media.Effects.BlurEffect   Radius  LeftMenuBtn �Name �� Orientation  Img ��Name  FocusVisual �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background 	 Button.Pressed.Border 
 Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  cabinetButton �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �    &	 �    &	 �    &	 �    &	 �    &	     &	 +    &		 N    &	
 q    &	 �    &	 �    &	 �    7  7  7  7 
 7  7  �� 5   
   " ��60   .R�5      � $	��Btn��6   $��50��6   $��20,0,0,0q�6*   .+�5      �� ._�5      � .+�5      �� #��z��6    
������ $��23(�5       $��Center=�5       ��5      �� 5   "   " ��6(   .�5   &   ��  � �� �#E3E2DF6U   	 5   &   �� 5   *   
 66   �� $ IsMouseOver�$	 Btn�� true6l   .a�5   .   ��  � ��
 �����6[   5   +   �� 5   *   
 66   ��  �� $ FindAncestor=�" ��$ 	IsPressed� true5   0   .a�5    .   ��  � �� �#E3E2DF6]   5!   +   �� 5"   *   
 66   ��  �� $ FindAncestor=�" ��$ 	IsFocused� true5&   0   .a�5'   .   ��  � ��
 �����6[   5(   +   5*   #   5,      �� 5-      #��z��6    
������ $��-3,0,0,0q�6]   $��Center=�6o   $��23(�6�   $
��Bold"�6�   ��5.      �� 5/   "   " ��6(   .�50   &   ��  � ��
 �����6S   �� 51   &    � y�$ Hidden=�6C   6T   	 52   &   �� 53   *   
 66   ��  �� $ FindAncestor=�" ��$ 	IsFocused� true57   ,   a�58   .   �� 59   2    �@J�Effect 5:   6     5;   :   $ 25Q�6E   6S   5=   3   �� 5>   2    � y�$ Visible=�6O   6a   5@   +   5B   #   5D      5E      ��5F      �� 5G      " ��6    	 5H      �� 5I   "   
 6.   ��  �� $ FindAncestor=�" ��$ 	IsPressed� true5M   (   .a�5N   &   ��  � ��$ 0,2,0,0q�6?   6Q   5O   #   5Q      5T      5U      5V      �� 5W   
   LeftMenuButton��" ��6F   .R�5X      � $	 Btn��6   $��50��6    .+�5Y      �� ._�5Z      �� $ 
Horizontal=�6!   .+�5[      �� #���  6    $��Center=�6K   $
��Left=�6f   $��30��6�   $��30��6�   $
��Fill=�6�   $��20,0,0,0q�6�   5]      �� 5^      #��z��6    
������ $��15(�5`      $��Center=�5a      ��5b      �� 5c   "   " ��6(   .�5d   &   ��  � �� �#E3E2DF6U   	 5e   &   �� 5f   *   
 66   �� $ IsMouseOver�$	 Btn�� true6l   .a�5g   .   ��  � ��
 �����6[   5h   +   �� 5j   *   
 66   ��  �� $ FindAncestor=�" ��$ 	IsFocused� true5n   0   .a�5o   .   ��  � ��
 �����6[   5p   +   5r   #   5t      5u      5v      �� 5w      $ MouseOverBorder��6   ���#ADADAD��5x      �� 5y      " ��6    .�5z      ��  �@J�Opacity$ 0Q�68   6D   	 5{      �� 5|   "   
 6.   �� $ IsMouseOver�$	 Btn�� true6d   .a�5}   &   ��  �@J�Opacity$	 0.1Q�6@   6N   5~   #   5�      5�      �� 5�      $ IsSelectedBorder��6   ���#ADADAD��5�      �� 5�      " ��6    .�5�      ��  �@J�Opacity$ 0Q�68   6D   	 5�      �� 5�   "   
 6.   ��  �� $ FindAncestor=�" ��$ 	IsFocused� true5�   (   .a�5�   &   ��  �@J�Opacity$	 0.1Q�6@   6N   5�   #   5�      5�      �� 5�      $ IsSelectedBorder2��6   
������ ��5�      �� 5�      " ��6    .�5�      ��  � y�$ Hidden=�6;   6L   �� 5�       � ��$ 3,0,0,0q�6@   6R   �� 5�       � �� �#E980746N   	 5�      �� 5�   "   
 6.   ��  �� $ FindAncestor=�" ��$ 	IsFocused� true5�   (   .a�5�   &   ��  � y�$ Visible=�6C   6U   5�   #   5�      5�      5�      5�      �� 5�   
   .�5�      ��  � �� 5�      �� 5�      .R�5�      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5�      5�      5�      �� 5�   
   $ 	#FFDDDDDD��6;   �� 5�   
   $ 	#FF707070��67   �� 5�   
   $ 	#FFBEE6FD��6>   �� 5�   
   $ 	#FF3C7FB1��6:   �� 5�   
   $ 	#FFC4E5F6��6<   �� 5�   
   $ 	#FF2C628B��68   �� 5�   
   $ 	#FFF4F4F4��6=   �� 5�   
   $ 	#FFADB2B5��69   �� 5�   
   $ 	#FF838383��6=   �� 5�   
   " ��6&   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 0q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $ border��6!   $ 15��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5�      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5�       5�      P� 5�       �@��IsDefaulted$
 true��6=   . �5�   "   �� $ border��6@   # � ��6T    � ��5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ border��6?    � �� �#da3f886S   �� 5�   "   $ border��6@    � �� �#da3f886T   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ border��6?    � �� �#da3a986S   �� 5�   "   $ border��6@    � �� �#da3a986T   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   �� 5�   "   $ contentPresenter��6K   8   � ��6i   5�      5�      5�      5�      5�      .��5�      �  � ColumnDefinitions 5�   
   �� 5�      $	��250 �6   6-   �� 5�      6"    � RowDefinitions 5�   
   �� 5�      $	��100 �6   6+   �� 5�      6   .+�5�   
   � -   5        $ MainGrid��5�      $��1��6!   $��2��6.   ��5�      �� 5�      -   5        GridBackGround��  j� Stretch$
  Fill=�5�   5   6F   5�      � 5�   
   -   5        $ TopMenu��5�      $��0��6    $��2��6-   .+�5�      �� $��2q�6   ���#44318D
������ ._�5�      �� $ 
Horizontal=�6   .+�5�      �� #��[  6   $
��PLAY��6W   6h   �� 5�      -   5        #��[  5�      $��COMMUNICATION��6W   6�   �� 5�      -   5        ! ��Name$! 
ShopButton��5�      #��[  6K   $
��SHOP��6�   6�   �� 5�      #��[  6   $
��NEWS��6W   6h   �� 5�      -   5        $! 
CabinetBtn��5�   E   #���  6   " � Cursor$
" Hand��6r   $	��300��6�   $��60��6�   ���#8265a8$��	290,0,0,0q�6�   .��5�      �� $ 
Horizontal=�6%   $��50��6>   .+�5�      �� $��\res\user.png��6$   $��40��6;   $��40��6F   6U   �� 5�      -   5        # ��Name$# UsernameInterface��5�   (   $
��Jaba��6C   ���#E3E2DF$
��Wrap=�6d   
������ $��36��6�   $	��250��6�   $ �� TextAlignment$
$ Left=�6�   $��10,0,0,0q�6�   $��24(�6�   5�      5�      5�      5�      5�      � 5�   
   -   5        $ 	SlideMenu��5�      $��0��6"   $��1��62   $
��Left=�6?   ��5      �� 5     " �6   .�5     ��  � ��$	 225��6.   6<   	 5     �� 5     
 6&   �� $ 	IsChecked�$ OpenClosedLeftMenuBtn�� true6l   .a�5     ��  � ��$ 56��66   6C   5     5	     .+�5     �� $��1,0,1,1q�6   ���#44318D6G   �� 5     $��0q�6   
���   �% J� Opacity$	% 0.4Q�6<   6L   �� 5     -	   5        & ��Name$& LeftMenuGame��5     $ Vertical=�6/   5?     d� 5@     -
   5        ' d�Name$' OpenClosedLeftMenuBtn��5@  -   $|�False��6   $��30��6L   $��30��6X   $��Bottom=�6c   $
��Left=�6~   $��20, 0, 0, 20q�6�   
���������5A     �� 5B     .R�5C     �� ��5D     �� 5E  "   " ��6(   .�5F  &   ��  � ��$I CC:\Users\user\source\repos\WpfApp1\WpfApp1\res\icons\closePanel.png��6?   6�   	 5G  &   �� 5H  *   
 66   ��  �� $ FindAncestor=�" d�$ 	IsChecked� true5L  4   .a�5M  .   ��  � ��$C =C:\Users\user\source\repos\WpfApp1\WpfApp1\res\icons\open.png��6G   6�   5N  +   5P  #   5R     5S     5U     5V     5W     5X     