   M S B A M L   `   `   `  ����N  JWorldMapOfResources, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WorldMapOfResources.DialogsWorldMapOfResources.Dialogs  5   	   7    1WorldMapOfResources.Dialogs.WindowEtiquetteDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   5local)clr-namespace:WorldMapOfResources.Dialogs  5   	     � Title$  WindowEtiquetteDialog��5	   	   $	��380��6'   $	��450��64    � WindowStyle$ 
ToolWindow=�6A    � 
ResizeMode$ NoResize=�6Z    � WindowStartupLocation$ CenterScreen=�6p   .��5
      � $
��Auto��6   $
��Auto��6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��70 �6   �� 5      $��60 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��200 �6   �� 5      $	��100 �6   .+�5   
   �� $
��Code��6   $��Candara)�6   
���   �$��Center=�6G   $��Center=�6k   $��Center=�6�   $
��Auto��6�   $��0��6�   $��0��6�   $��25(�6�   �� 5   
   $��Color��6   $��Candara)�6    
���   �$��Center=�6H   $��Center=�6l   $��Center=�6�   $
��Auto��6�   $��0��6�   $��1��6�   $��25(�6�   �� 5   
   $��Description��6   $��Candara)�6&   
���   �$��Center=�6N   $��Center=�6r   $��Center=�6�   $
��Auto��6�   $��0��6�   $��2��6�   $��25(�6�   �� 5   
   $��Italic$�6.   $��Candara)�6A   ���	#FF939191$��40��6n   $	��180��6z   $��1��6�   $��0��6�   $��25(�6�   $��Center=�6�   ��6   ��  �� Path$
 Code�6�   #  Xceed.Wpf.Toolkit.ColorPicker  5   
   $��1��6   $��1��6(   $��40��68   $	��180��6D      DisplayColorAndName . 6P   �� 5!   
   $��75��65   $��Candara)�6A   $��Italic$�6V   ���	#FF939191$	��178��6�   $��1��6�   $��2��6�   $��25(�6�   $��Center=�6�   $��12,10.4,10,35.2q�6�   $��2��6�   ��6   �� $ Description�6�   �� 5#   
   $��1��6   $��Cancel��6!   $��4��62   $��70��6?   $��30��6J   $��Right=�6V   ���	#FFCA1616���	#FFFFFDFD$��0,15.8,13,15q�6�   �� 5$   
   -   5        $��2��5$      $��Ok��6!   $��4��6.   $��70��6;   $��30��6F   ���	#FFFCFBFB���	#FF339943$��4,15.8,26,15q�6�   6�   5'      5(      