   M S B A M L   `   `   `  ����U  QAssignment3-CarServiceShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Assignment3_CarServiceShopAssignment3_CarServiceShop  5   	   +    %Assignment3_CarServiceShop.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Assignment3_CarServiceShop     5   	     � Title$  
MainWindow��5   	   $	��675��6   $
��1250��6)   .��5	      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5    
   �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5*   
   �� -   5        $��CustomerInformationLabel��5*      $��Customer Information��60   $��0��6O   $��0��6\   $��2��6l   $��Center=�6�   $��Center=�6�   $��5q�6�   $��15(�6�   $
��Bold"�6�   �� 5-   
   -   5        $��FirstNameLabel��5-      $��First Name:��6&   $��1��6<   $��0��6I   $��Right=�6Y   $��5q�6u   $��15(�6�   �� 5.   
   -   5        $��FirstNameTextBox��5.      $��1��6*   $��1��67   $��Center=�6G   $��5q�6i   $��15(�6t    � ToolTip$  Enter your first name here��6�   $��0��6�   �� 51   
   -   5        $��LastNameLabel��51      $��
Last Name:��6%   $��2��6:   $��0��6G   $��Right=�6W   $��5q�6s   $��15(�6~   �� 52   
   -   5        $��LastNameTextBox��52      $��2��6)   $��1��66   $��Center=�6F   $��5q�6h   $��15(�6s   $ Enter your last name here��6�   $��1��6�   �� 55   
   -   5        $��PhoneNumberLabel��55      $��Phone Number:��6(   $��3��6@   $��0��6M   $��Right=�6]   $��5q�6y   $��15(�6�   �� 56   
   -   5        $��PhoneNumberTextBox��56      $��3��6,   $��1��69   $��Center=�6I   $��5q�6k   $��15(�6v   $J DEnter your phone number here. Phone number must be a 10 digit number��6�   $��2��6�   �� 59   
   -   5        $��CarInformationLabel��59      $��Car Information��6+   $��5��6E   $��0��6R   $��2��6b   $��Center=�6v   $��Center=�6�   $��5q�6�   $��15(�6�   $
��Bold"�6�   �� 5<   
   -	   5        $��	MakeLabel��5<      $��Make:��6!   $��6��61   $��0��6>   $��Right=�6N   $��5q�6j   $��15(�6u   �� 5=   
   -
   5        $��MakeComboBox��5=      $��6��6'   $��1��64   $��Center=�6D   $��5q�6f   $��15(�6q   $J DSelect the company that manufactured your car from the dropdown menu��6   $��3��6�   �� 5@   
   -   5        $��
ModelLabel��5@      $��Model:��6"   $��7��63   $��0��6@   $��Right=�6P   $��5q�6l   $��15(�6w   �� 5A   
   -   5        $��ModelTextBox��5A      $��7��6&   $��1��63   $��Center=�6C   $��5q�6e   $��15(�6p   $&  Enter the model name of your car��6~   $��4��6�   �� 5D   
   -   5        $��	YearLabel��5D      $��Year:��6!   $��8��61   $��0��6>   $��Right=�6N   $��5q�6j   $��15(�6u   �� 5E   
   -   5        $��YearComboBox��5E      $��8��6'   $��1��64   $��Center=�6D   $��5q�6f   $��15(�6q   $B <Select year your car was manufactured from the dropdown menu��6   $��5��6�   �� 5H   
   -   5        $��ColourLabel��5H      $��Colour:��6#   $��9��65   $��0��6B   $��Right=�6R   $��5q�6n   $��15(�6y   �� 5I   
   -   5        $��ColourTextBox��5I      $��9��6'   $��1��64   $��Center=�6D   $��5q�6f   $��15(�6q   $" Enter the colour of your car��6   $��6��6�   �� 5L   
   -   5        $��ServicesLabel��5L      $��	Services:��6%   $��10��69   $��0��6G   $��Right=�6W   $��5q�6s   $��15(�6~   �� 5M   
   -   5        $��EngineOilChangeCheckBox��5M      $��Engine Oil Change��62   $��10��6N   $��1��6\   $��Center=�6l   $4 .Check this if you need your Engine Oil Changed��6�   $��7��6�   �� 5N   
   -   5        $#��TransmissionOilChangeCheckBox��5N      $��Transmission Oil Change��68   $��11��6Z   $��1��6h   $��Center=�6x   $: 4Check this if you need your Transmission Oil Changed��6�   $��8��6�   �� 5O   
   -   5        $��AirFilterChangeCheckBox��5O      $��Air Filter Change��62   $��12��6N   $��1��6\   $��Center=�6l   $5 /Check this if you need your Air Filther Changed��6�   $��9��6�   �� 5R   
   -   5        $��	CostLabel��5R      $��Cost:��6!   $��13��61   $��0��6?   $��Right=�6O   $��5q�6k   $��15(�6v   �� 5S   
   -   5        $��CostTextBox��5S      $��$��6%   $��13��6.   $��1��6<   $��Center=�6L   $��5q�6n    �� 
IsReadOnly$
 True��6y   $��15(�6�   
���   �
�������$&  The total cost with show up here��6�   $��10��6�   �� 5V   
   -   5        $��CarServiceSummaryLabel��5V      $��Car Service Summary��6.   $��0��6L   $��2��6Y   $��4��6i   $
��Left=�6}   $��Center=�6�   $��5q�6�   $��15(�6�   $
��Bold"�6�   $ List of cars��6�   �� 5W   
   -   5        $��CarServiceSummaryListView��5W      $��2��64   $��1��6D   $��4��6Q   $��13��6e   $��5q�6w   $ Car serive summary list��6�   $��11��6�    �� View 5X      �� 5Y      .P�5Z      �� $��#��6%    �� Width$ 35��60    �� DisplayMemberBinding 6;   �� *
GetCount+�� 5[      -   5        	FirstName��$��
First Name��5[   8   $	 125��6L    6X   �� *GetFirstName+�� 5\      $��	Last Name��6%   $	 125��68    6D   �� *GetLastName+�� 5]      $��Phone��6%   $	 125��64    6@   �� *GetPhoneNumber+�� 5^      $
��Make��6%   $	 100��63    6?   �� *	GetMake+�� 5_      $��Model��6%   $	 125��64    6@   �� *
GetModel+�� 5`      $
��Year��6%   $ 75��63    6>   �� *	GetYear+�� 5a      $��Colour��6%   $	 110��65    6A   �� *	GetColour+5b      5d      �� 5g   
   -   5        $��	AddButton��5g      $	��Add��6"   $��15��60   $��0��6>   $��5q�6N   $ Add a car to the summary��6n   $��12��6�   �� 5h   
   -   5        $��	NewButton��5h      $	��New��6"   $��15��60   $��1��6>   $��5q�6N   $4 .Resets all inputs without clearing the summary��6q   $��13��6�   �� 5i   
   -   5        $��UpdateButton��5i      $��Update��6%   $��15��66   $��2��6D   $��5q�6T   $+ %Modify or Update a car in the summary��6t   $��14��6�   �� 5j   
   -   5        $��RemoveButton��5j      $��Remove��6%   $��15��66   $��3��6D   $��5q�6T   $. (Remove the selected car from the summary��6z   $��15��6�   �� 5k   
   -   5        $��RemoveAllButton��5k      $��
Remove All��6(   $��15��6=   $��4��6K   $��5q�6[   $ Clears the entire window��6�   $��16��6�   �� 5l   
   -   5        $
��Exit��5l      $
��Exit��6   $��15��6,   $��5��6:   $��5q�6J   $ Exits the program��6h   $��17��6�   5p      5q      