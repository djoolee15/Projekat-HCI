   M S B A M L   `   `   `  ����G  CProjekat HCi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Projekat_HCiProjekat_HCi  5   	   +    %Projekat_HCi.PocetnaUlogovaniMenadzer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Projekat_HCi     5   	     � Title$  Menadzer��5   	   $	��600��6   $
��1000��6'    � Icon$r lC:\Users\djole\OneDrive\Desktop\git skinuo hci\Projekat-HCI\Projekat HCi\Projekat HCi\Model\-train_90433.ico��5	   	    � 	Resources 5         Ctr1 �� Text  Ctr2  Ctr3  Ctr4  Ctr5  Ctr6  Ctr7�� 5   
   %P  &	        &	 &     &	 L     &	 r     &	 �     &	 �     &	 �     �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   �� 5      $ Another Text��6+   5       J� InputBindings 5      �� 5   
   
 �� Key$ F1��6    �� 	Modifiers$
 Ctrlf�6    �� Command# [  6/   �� 5   
   $ F2��6   $
 Ctrlf�6   # [ 6/   �� 5   
   $ F3��6   $
 Ctrlf�6   # [ 6/   �� 5   
   $ F4��6   $
 Ctrlf�6   # [ 6/   �� 5   
   $ F5��6   $
 Ctrlf�6   # [ 6/   �� 5   
   $ F6��6   $
 Ctrlf�6   # [ 6/   �� 5   
   $ F7��6   $
 Ctrlf�6   # [ 6/    J� CommandBindings 5       )  #System.Windows.Input.CommandBinding  5!   
   -   5        	   Command#	 [  5!      69     5"   
   -   5        #	 [ 5"      69     5#   
   -   5        #	 [ 5#      69     5$   
   -   5        #	 [ 5$      69     5%   
   -   5        #	 [ 5%      69     5&   
   -   5        #	 [ 5&      69     5'   
   -   5        #	 [ 5'      69   .��5)      � .+�5*   
   ]� .+�5+      � $	��Top=�6   
 � ColumnDefinitions
 5,      �� 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      .+�54      �� -   5        $��iredavoznje��54      $��Izmena Reda Voznje��6,   
����  �
�������$��0��6p   $	��100��6�   $��0,0,0,0q�6�   6�   �� 55      -	   5        $��ivoznihlinija��55      $��Izmena Voznih Linija��6.   
�������
���   �$��1��6t   $	��100��6�   $��0,0,0,0q�6�   6�   �� 56      -
   5        $��ivozova��56      $��Izmena Vozova��6(   
�������
���   �$��2��6g   $	��100��6y   $��0,0,0,0q�6�   6�   �� 57      -   5        $��ppmesec��57      $��Pregled Prodaje - Mesec��6(   
�������
���   �$��3��6q   $	��100��6�   $��0,0,0,0q�6�   6�   �� 58      -   5        $��ppvoznja��58      $��Pregled Prodaje - Voznja��6)   
�������
���   �$��4��6s   $	��100��6�   $��0,0,0,0q�6�   6�   �� 59      $��5��6    �� Orientation$ 
Horizontal=�6.   .+�5:      �� -   5        $��
HelpButton��5:      $��Pomoć��6/   $��20,20,10,20q�6?   6T   �� 5;      -   5        $��LogOut��5;      $��Odjava��6+   
�������
���   �$��50��6e   $��25,10,25,10q�6s   6�   5=      5>       � 5?      -   5          �Name$ PocetnaMenadzer��5?      $��Bottom=�6-   5@      5A      5B      