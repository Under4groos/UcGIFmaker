   M S B A M L   `   `   `  ����C  ?UcStylus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UcStylusUcStylus  5   	   5clr-namespace:UcStylus.ControlsUcStylus.Controls  6.       UcStylus.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:UcStylus     5   	   4controlsclr-namespace:UcStylus.Controls     6.     � AllowsTransparency  .  � WindowStyle$
 None=�5   	   $
��1080��5	   	   $
��1920��6   ���	#FFACACAC � Title$ UcStylus��5   	   ��6   Z�  � 	Resources 5         bck_ �� Color  style_label �� 
TargetType �� Property �� Value  style_border �� Triggers	 P� Property
 P� Value 
 grid_h��%  &	        &	 (     &	 �     7   &	 C    �� 5   
   $ 	#33FFFFFF��6'   6<   �� 5   
   " ��6$   .�5      ��  � ��
 �����6+   �� 5       � ��$ 10(�6)   �� 5       � ��$ 0q�6'   �� 5       � ��$ 0,5,0,0q�6(   5      �� 5   
   " ��6%   .�5      ��  � ��8   6K   �� 5       � ��$ 4q�6'   63   �� 5       �@��CornerRadius$ 5��6-   69   �� 5       � ��$ 40��6&   63   �� 5       � ��$ 40��6'   64    5      P� 5      	 �@J�IsMouseOver
 . . �5      ��  � �� �	#B2FFFFFF6G   5      5       �� 5!   
   " �6    5"      P� 5#      	 �@J�IsMouseOver
 .  . �5$      ��  � y�$ 	Collapsed=�63   6G   5%      5'      5(      .��5)      � .+�5*   
   � -   5         �Name$ grid_m��5*      � 5+   
   .+�5-      � .+�5.      �� -   5         ��Name$ PanelInkCanvas��5.      |�.  �� 
Background 6E   Z�  �� DefaultDrawingAttributes 5/      *  $System.Windows.Ink.DrawingAttributes  50      -   5        DrawingAttributes_��   Width$ 10Q�50   H      Height$ 10Q�6S      Color$ 	#FF51CFFF��6`   53      54      55      A� 57   
   -   5         A�Name$ EllipseCursor��57      $y�	Collapsed=�6*   $
��Left=�6B   $	��Top=�6]   $��12��6u   $��12��6�   ���	#FF0074FF$��2��6�   6�   � 58   
   -   5        $ grid_informations��58      $��Bottom=�6+   $
��Left=�6F   ���	#7FFFFFFF$��	10,0,0,10q�6x   .+�59      �� $��0,0,40,0q�6   .+�5:      "   UcStylus.Controls.MultiLabel  -   5          Name$ ActiveDevice��5:   )     5;      -   5        $ StylusButtonState��5;   )     5<      -   5        $ StylusCurPos��5<   )     5=      -	   5        $ PenSize��5=   )   5>      5@      � 5A   
   $��Center=�6   $��Bottom=�6,   $��0,0,0,10q�6G   .+�5B      ��  �� Orientation$ 
Horizontal=�6   .+�5C      �� -
   5        #��[ 5C      $��Right=�6?   $��Bottom=�6[   ._�5D      �� $	����6   $1��+/UcStylus;component/font/#Segoe MDL2 Assets)�6/   $��0q�6h   $��30(�6t   
���   �$��Center=�6�   $��Center=�6�   6�   5E      �� 5F      -   5        #��[ 5F      $��Right=�6?   $��Bottom=�6[   ._�5G      �� $	����6   $1��+/UcStylus;component/font/#Segoe MDL2 Assets)�6/   $��0q�6h   $��30(�6t   
���   �$��Center=�6�   $��Center=�6�   6�   5H      �� 5I      -   5        #��[ 5I      $��Right=�6?   $��Bottom=�6[   ._�5J      �� $	����6   $1��+/UcStylus;component/font/#Segoe MDL2 Assets)�6/   $��0q�6h   $��30(�6t   
���   �$��Center=�6�   $��Center=�6�   5K      �� 5M      -   5        #��[ 5M      $��Right=�6?   $��Bottom=�6[   ._�5N      �� $	����6   $1��+/UcStylus;component/font/#Segoe MDL2 Assets)�6/   $��0q�6h   $��30(�6t   
���   �$��Center=�6�   $��Center=�6�   5O      �� 5P      -   5        #��[ 5P      $��Right=�6?   $��Bottom=�6[   ._�5Q      �� $	����6   $1��+/UcStylus;component/font/#Segoe MDL2 Assets)�6/   $��0q�6h   $��30(�6t   ���	#FF5900B7$��Center=�6�   $��Center=�6�   5R      5T      5U      � 5V   
   -   5        $ grid_dop��5V      $y�Hidden=�6!   $	��Top=�66   $��Center=�6N   $	��384��6k   $	��200��6w   #��[  6�   $��	0,818,0,0q�6�   .+�5W      � 5\      5]      � 5^   
   -   5        $ grid_setting��5^      $y�Hidden=�6%   $��60q�69   ���	#19FFFFFF.+�5_      �� $
��Left=�6   $	��Top=�60   $��UcStylus��6H   $��16(�6[   $��2q�6i   
����������	#33000000$��10q�6�   6�   �� 5a      $��Уть!��6   $��72(�6#   ���	#33FFFFFF$��Center=�6H   $��Center=�6e   6�   �� 5b      $��
by UnderKo��6   $��36(�6)   ���	#992B00FF$��Right=�6N   $��Bottom=�6j   6�   5c      5d      5e      