   M S B A M L   `   `   `  ����K  GSimpleTrader.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SimpleTrader.WPF.ViewsSimpleTrader.WPF.Views  5      $    SimpleTrader.WPF.Views.BuyView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:SimpleTrader.WPF.Views     5      .��5	      � $��20q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��Center=�6   $��0��61   $��0 20 0 0q�6?   .+�5      �� $	��100��6   ��6"   �� *Symbol+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��5 0 0 0q�6   $��Search��6&   ��67   �� *SearchSymbolCommand+5      � 5   
   $��0 20 0 0q�6   $��1��6!   $	��500��6.   ��5      �� 5       �� 
TargetType" �6    �� Triggers 5      �� 5       �� Binding 6&   �� *SearchResultSymbol+ �� Value  6M   .a�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;   5      5       � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��2* �6#   .+�5#      �� $��0��6   
�������$��1q�68   	 �� Padding$	 20q�6L   
 �� CornerRadius$
 3 0 0 3��6Y   ._�5$      �� $��Center=�6   .+�5%      �� $��Center=�6    $��32(�6=   ��6K   �� *SearchResultSymbol+�� 5&      $��0 10 0 0q�6    ��62   �� *
StockPrice+ �� StringFormat$ {0:C}��5'      5(      �� 5)      $��1��6   
�������$��0 1 1 1q�68   $	 20q�6S   $
 0 3 3 0��6`   ._�5*      �� $��Center=�6   .+�5+      � $
��0 10q�6    .+�5,      �� $	��150��6$   $��Shares to buy:��60   �� 5-      $��50��6"   ��6-   �� *SharesToBuy+$ PropertyChanged=� �� FallbackValue$ 1��5.      � 5/      $
��0 10q�6    .+�50      �� $	��150��6$   $��Price per share:��60   �� 51      $��50��6$   ��6/   �� *
StockPrice+$ {0:C}��52      �� 53      $��Center=�6    $��32(�6=   $
��0 10q�6K   ��6Y   �� *
TotalPrice+$ {0:C}���� 54      $
��0 10q�6   $
��20 5q�6+   $��24(�6:   $	��Buy��6H   ��6V   �� *BuyStockCommand+55      56      57      5;      5<      