   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $
��1280��6   $	��720��6)   $��Center=�67   $��Center=�6T   .��5      �  � RowDefinitions 5	   
   �� 5
      $��* �6   6)   �� 5      $��40 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��UsersDataGrid��5      $��4��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         CanUserDeleteRows$ False��5         CanUserAddRows$ False��5         AutoGenerateColumns$ False��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *Login+6T     5      $ Пароль��6)   	 69   �� *
Password+6X     5      $ Имя��6)   	 66   �� *Name+6Q     5      $ Фамилия��6)   	 6:   �� *	Surname+6X     5      $ Отчество��6)   	 6;   �� *
Fathername+6\   5         5!   
   -   5        $��UsersPlusGrid��5!   D   $��0��6   $��4��6    $��0��64   $ * 5"      $ False��5#      $ False��5$      $ False��5%       5&        5'      $ 
Логин��6%   	 64   �� *Login+6P     5(      $ Пароль��6%   	 65   �� *
Password+6T     5)      $ Имя��6%   	 62   �� *Name+6M     5*      $ Фамилия��6%   	 66   �� *	Surname+6T     5+      $ Отчество��6%   	 67   �� *
Fathername+6X     5,      $ Роль��6%   	 63   �� *RoleNavigation.Name+6]   5.      �� 5/   
   -   5        $��1��5/      $��0��6   $��ConfirmChanges��6.   6f   �� 50   
   -   5        $��1��50      $��1��6   $��Delete��6.   6^   �� 51   
   -   5        $��1��51      $��2��6   $��Create��6.   6V   �� 52   
   -   5        $��1��52      $��3��6   $
��Find��6.   6R   53      54      