   M S B A M L   `   `   `  ����G  CProjekat HCi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Projekat_HCi.PagesManagerProjekat_HCi.PagesManager  5      /    )Projekat_HCi.PagesManager.IzmenaRedVoznje   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Projekat_HCi.PagesManager     5        N� Title$  IzmenaRedVoznje��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .     AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   ��6$   ��  �� Path$ red_voznje_prikaz_str�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Naziv Voza��6%   
   MinWidth$	
 100Q�69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *
Naziv_voza+6i     5      $	 Polazak��6%   $	
 100Q�66    6E   �� *	Polazak+6c     5      $	 Dolazak��6%   $	
 100Q�66    6E   �� *	Dolazak+6c     5      $	 Datum Voznje��6%   $	
 100Q�6;    6J   �� *DatumVoznje+6l   5      � 5   
   $��0��6   $��1��6    � DataContext 6,   ��  �� ElementName$ dgrMain��$ SelectedItem� 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6     5'      �� 5(      $
��Auto �6#   �� 5)      .+�5,      �� $��0��6   $��0��6(   Datum Vožnje :6E   �� 5-      -   5        $��naziv_1��5-      $��1��6%   $��0��65   ��6B   �� $ DatumVoznje�6f   �� 5.      $��1��6   $��2��6)    �� Orientation$ 
Horizontal=�66   .+�5/      �� -   5        $��Obrisi ovu vožnju��5/      $��
20,10,20,0q�6J   $	��100��6^   51      �� 52      $��
20,10,20,0q�6   $��0��6,   $��3��6<   $��2��6I   DODAVANJE NOVE VOŽNJE6t   �� 54      $��
20,10,20,0q�6   $��0��6,   $��4��6<   Izaberite Voz :6Z   �� 55      -   5        $��CmbVoz��55      $��4��6%   $��1��62   $��
20,10,20,0q�6B   $	��100��6V   ��56      �� 57      .R�58      �� ��6$   �� *Naziv+59      5;      �� 5<      $��
20,10,20,0q�6   $��0��6-   $��5��6=   Izaberite Voznu Liniju :6d   �� 5=      -   5        $��cmbVoznaLinija��5=      $��5��6-   $��1��6:   $��
20,10,20,0q�6J   $	��100��6^   ��5>      �� 5?      .R�5@      �� .+�5A      �� ��6(   �� *	Polazak+�� 5B      ��6(   �� *Dolaz+5C      5D      5F      �� 5G      $��0��6   $��6��6(   $��
20,10,20,0q�66   Unesite Datum Vožnje :6c   �� 5H      -   5        $��datumBx��5H      $��1��6&   $��6��66   $��
20,10,20,0q�6C   �� 5I      -   5        $��Dodajte Novu Voznju��5I      $��
20,10,20,0q�6J   $	��100��6^   $��1��6m   $��7��6}   5L      5M      5N      