   M S B A M L   `   `   `  ����G  CProjekat HCi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Projekat_HCi.PagesManagerProjekat_HCi.PagesManager  5      -    'Projekat_HCi.PagesManager.PregledVoznja   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Projekat_HCi.PagesManager     5        N� Title$  PregledVoznja��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   ��6$   ��  �� Path$ prodate_karte_prikaz�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID Karte��6)   
   MinWidth$	
 100Q�6<      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *Id+5      5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $	 
Naziv Voza��6%   $	
 100Q�6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *
Naziv_voza+6j     5      $	 Polazak��6%   $	
 100Q�67    6F   �� *	Polazak+6d     5       $	 Dolazak��6%   $	
 100Q�67    6F   �� *	Dolazak+6d     5!      $
	 Cena��6%   $	
 100Q�64    6C   �� *Cena+6^     5"      $	 Korisnik��6%   $	
 100Q�68    6G   �� *KorisnickoImeKupca+6p    �� 
GroupStyle 5&      (  "System.Windows.Controls.GroupStyle  5'         HeaderTemplate 5(      �� 5)      .R�5*      �� $ 
Horizontal=�6)   .+�5+   "   �� $��ID Voznje: ��6,   6A   �� 5,   "   $
��Bold"�6B   ��6,   �� *Name+6B   5-      5.      50      52      53      54      