   M S B A M L   `   `   `  ����G  CProjekat HCi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Projekat_HCi.PagesManagerProjekat_HCi.PagesManager  5      1    +Projekat_HCi.PagesManager.IzmenaVozneLinije   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Projekat_HCi.PagesManager     5        N� Title$  IzmenaVozneLinije��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .     AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6~   ��6$   ��  �� Path$ linije_prikaz�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   MinWidth$	
 100Q�61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Id+6Y     5      $	 Polazak��6%   $	
 100Q�66    6E   �� *	Polazak+6c     5      $	 Dolazak��6%   $	
 100Q�66    6E   �� *	Dolazak+6c   5      � 5   
   $��0��6   $��1��6    � DataContext 6,   ��  �� ElementName$ dgrMain��$ SelectedItem� 5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6     5&      �� 5'      $
��Auto �6#   �� 5(      .+�5*      �� $��0��6   $��1��6(   Id:6:   �� 5+      $��0��6   $��2��6(   
Polazak:6?   �� 5,      $��0��6   $��3��6(   
Dolazak:6?   �� 5-      -   5        $
��id_1��5-      $��1��6"   $��1��62   ��6?   �� $ Id�6Z   �� 5.      -   5        $
��br_m��5.      $��1��6"   $��2��62   ��6?   �� $ Polazak�6_   �� 5/      -   5        $
��br_v��5/      $��1��6"   $��3��62   ��6?   �� $ Dolazak�6_   �� 50      $��1��6   $��4��6)    �� Orientation$ 
Horizontal=�66   .+�51      �� -   5        $��Obrisi��51      $��	20,0,20,0q�6?   $	��100��6R   �� 52      -   5        $��Dodaj��52      $��	20,0,20,0q�6@   $	��100��6S   53      54      55      56      