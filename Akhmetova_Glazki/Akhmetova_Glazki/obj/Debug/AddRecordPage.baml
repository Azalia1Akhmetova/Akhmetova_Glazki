   M S B A M L   `   `   `  ����K  GAkhmetova_Glazki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Akhmetova_GlazkiAkhmetova_Glazki  5      $    Akhmetova_Glazki.AddRecordPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Akhmetova_Glazki     5        N� Title$  AddRecordPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��80 �6   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $'��!Название продукта��6   $��Center=�61   $��10q�6L   $��16(�6X   �� 5      -   5        $��Products��5   H    �� DisplayMemberPath$ Title��6.    �� IsTextSearchEnabled .   �� 
IsEditable . $��20��5   )   $	��400��65    �� Text 5      �� *Title+5   C   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $��Дата продажи��6   $��Center=�6,   $��10q�6G   $��16(�6S   (  "System.Windows.Controls.DatePicker  5       -   5        $��ProductSaleDate��5       $��Center=�60   $��16(�6K   5!      �� 5#   
   $��2��6   $ 
Horizontal=�6"   .+�5$      �� $��Количество��6   $��Center=�6*   $��10q�6E   $��16(�6Q   �� 5%      -   5        $��ProductCount��5%      $��20��6H   $��80��6T   ��6*   �� *ProductCount+6T   5&      �� 5(   
   -   5        $��
SaveRecord��5(   2   $��3��6   $��Сохранить��6   $
��Left=�6]   $��Bottom=�6x   $��10q�6�   6�   5)      5*      