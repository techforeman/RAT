   M S B A M L   `   `   `  ����B  >RAT.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RAT.WPFRAT.WPF  5   	       RAT.WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RAT.WPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��900��6)    � 	Resources 5
         	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%~  &	        &	 �     �� 5   
   .��5      U� $ (Grid.Width)�6,   $
 grid��6U   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.4��6'   $ 70Q�69   5      5      �� 5   
   .��5      U� $ (Grid.Width)�6,   $
 grid��6U   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.4��6'   $	 200Q�69   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � ���	#FFCBCBCB$��1��6&   .+�5      � $��0 20 0 0q�6   ���	#FFEEEEEE.+�5      � $	��100��6   ���	#FFEEEEEE$	��Top=�6;   $��Stretch=�6S   $��10q�6q    5       �� 5!      $��* �6+   �� 5"      $��* �6+   �� 5#      $��* �6+   �� 5$      $��* �6+   .+�5'      �� 
�������$��0 0 1 0q�61   $��0��6K   ._�5(      �� $��30(�6$   $��First Label��62   
���   �$��15q�6X   5)      �� 5*      
�������$��0 0 1 0q�61   $��1��6K   ._�5+      �� $��30(�6$   $��Second Label��62   
���   �$��15q�6Y   5,      �� 5-      
�������$��0 0 1 0q�61   $��2��6K   ._�5.      �� $��30(�6$   $��Third Label��62   
���   �$��15q�6X   5/      �� 50      
�������$��0 0 1 0q�61   $��3��6K   ._�51      �� $��30(�6$   $��Fourth Label��62   
���   �$��15q�6Y   52      53      54      55      � 57   
   -   5         �Name$
 grid��57      $	��200��6   ���	#FF6c6c8D J� RenderTransformOrigin$ 0.5,0.5&�6@   $��0��6`   .+�58      �� -   5        	 ��Name$	 button��58      $��Right=�6%   $	��Top=�6A   $��10q�6Y     MaterialDesignFlatButton#��[ 6e   .��59      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 Menu=�6*   
�������66   5:      5;      5<      5=      