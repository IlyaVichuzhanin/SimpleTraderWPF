   M S B A M L   `   `   `  ����K  GSimpleTrader.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SimpleTrader.WPF.State.Navigators!SimpleTrader.WPF.State.Navigators  5      A%clr-namespace:SimpleTrader.WPF.ModelsSimpleTrader.WPF.Models  5      I)clr-namespace:SimpleTrader.WPF.ViewModelsSimpleTrader.WPF.ViewModels  5	      I)clr-namespace:SimpleTrader.WPF.ConvertersSimpleTrader.WPF.Converters  5
      -    'SimpleTrader.WPF.Controls.NavigationBar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?nav/clr-namespace:SimpleTrader.WPF.State.Navigators     5      8models%clr-namespace:SimpleTrader.WPF.Models     5      8vm)clr-namespace:SimpleTrader.WPF.ViewModels     5	      @
converters)clr-namespace:SimpleTrader.WPF.Converters     5
        � 	Resources  5      @   :SimpleTrader.WPF.Converters.EqualValueToParameterConverter "  EqualValueToParameterConverter��%   &	          5   
   64   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Padding$ 10q�6!   $��28(�6.   $��Simple Trader��6<   
�������  BrushPrimary1#��[ 6d   � 5   
   $��1��6    �� EdgeMode$ Aliased=�6     BrushPrimary2#��[ 6=     5       �� 
TargetType  	NavButton �� BasedOn��%0   '	�       7  �� 5      " 	�6   8   61   5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5       $
��Auto �6#   �� 5!      $
��Auto �6#   �� 5"      $��* �6#   .+�5%      	� $��0��6   $
��Home��5&      0   *SimpleTrader.WPF.State.Navigators.ViewType   Home#��Z 5(      ��5'      �� *UpdateCurrentViewModelCommand+ d� 	IsChecked 5)      �� *CurrentViewModel+	 �� Mode$	 OneWay=�
 �� 	Converter#
 [   �� ConverterParameter/   )SimpleTrader.WPF.ViewModels.HomeViewModel"  	� 5*      $��1��6   $��	Portfolio��5+         	Portfolio#��Z 5-      ��5,      �� *UpdateCurrentViewModelCommand+ 5.      �� *CurrentViewModel+$	 OneWay=�#
 [  4   .SimpleTrader.WPF.ViewModels.PortfolioViewModel"  	� 5/      $��2��6   $	��Buy��50      
   Buy#��Z 52      ��51      �� *UpdateCurrentViewModelCommand+ 53      �� *CurrentViewModel+$	 OneWay=�#
 [  .   (SimpleTrader.WPF.ViewModels.BuyViewModel"  	� 54      $��3��6   $
��Sell��6*   55      56      57      