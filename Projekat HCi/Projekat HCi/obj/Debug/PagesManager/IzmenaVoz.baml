   M S B A M L   `   `   `  ����G  CProjekat HCi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Projekat_HCi.PagesManagerProjekat_HCi.PagesManager  5      )    #Projekat_HCi.PagesManager.IzmenaVoz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Projekat_HCi.PagesManager     5      -   5          N�Name$  
izmena_voz��5       N� Title$ 	IzmenaVoz��5
      .��5      �  � RowDefinitions 5      �� 5   
   �� 5   
    � ColumnDefinitions 5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .     AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6z   ��6    ��  �� Path$ vozovi_prikaz�	   Columns	 5   
   4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Naziv��6%      MinWidth$	 100Q�64      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *Naziv+5      5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $
 ID��6%   $	 100Q�61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Id+6Y     5       $
 
Broj Mesta��6%   $	 100Q�69    6H   �� *
Broj_mesta+6i     5!      $
 Broj Vagona��6%   $	 100Q�6:    6I   �� *Broj_vagona+6k   5&      � 5'      $��0��6   $��1��6    � DataContext 6(   ��  �� ElementName$ dgrMain��$ SelectedItem� 5(   
   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6    50   
   �� 51      $
��Auto �6   �� 52      .+�54   
   �� $��0��6   $��0��6$   	Naziv :6:   �� 55   
   $��0��6   $��1��6$   Id:67   �� 56      $��0��6   $��2��6(   Broj Mesta:6C   �� 57      $��0��6   $��3��6(   Broj Vagona:6C   �� 58      -   5        $��naziv_1��58      $��1��6%   $��0��65   ��6B   �� $ Naziv�6`   �� 59   
   -   5        $
��id_1��59      $��1��6   $��1��6.   ��6;   �� $ Id�6V   �� 5:   
   -   5        $
��br_m��5:      $��1��6   $��2��6.   ��6;   �� $ 
Broj_mesta�6^   �� 5;   
   -   5        $
��br_v��5;      $��1��6   $��3��6.   ��6;   �� $ Broj_vagona�6_   �� 5<      $��1��6   $��4��6)   $ 
Horizontal=�66   .+�5=      �� -   5        $��Obrisi��5=      $��	20,0,20,0q�6?   $	��100��6R   �� 5>      -   5        $��Dodaj��5>      $��	20,0,20,0q�6@   $	��100��6S   5?      5@      5A      5B      