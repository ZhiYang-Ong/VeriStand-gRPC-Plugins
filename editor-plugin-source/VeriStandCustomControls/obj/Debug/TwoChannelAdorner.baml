   M S B A M L   `   `   `  ����f  bNationalInstruments.VeriStand.Configuration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null�fclr-namespace:NationalInstruments.VeriStand.Shell;assembly=NationalInstruments.VeriStand.Configuration#NationalInstruments.VeriStand.Shell  5      8 4NationalInstruments.VeriStand.CustomControlsExamplesL   FNationalInstruments.VeriStand.CustomControlsExamples.TwoChannelAdorner   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ` \NationalInstruments.Controls.Numerics, Version=9.0.0.0, Culture=neutral, PublicKeyToken=nullc _NationalInstruments.Controls.MocControls, Version=9.0.0.0, Culture=neutral, PublicKeyToken=nullW SNationalInstruments.Controls, Version=9.0.0.0, Culture=neutral, PublicKeyToken=nullBni5http://schemas.ni.com/controls/2009/xaml/presentation    5      vshellfclr-namespace:NationalInstruments.VeriStand.Shell;assembly=NationalInstruments.VeriStand.Configuration    5        � 	Resources  5       �� 
TargetType %  !_textBoxForMultiLineValueAdorners �� Property �� Value �� 
TargetType �Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard	 �� 
TargetName
 �� TargetProperty �� KeyTime �� Value O� KeyTime O� Value ��Name �� CornerRadius J� Opacity ��Name J� IsHitTestVisible  Button_Template��%n  &	        &	     �� 5
   
   " ��6   %!_textBoxForMultiLineValueAdorners��.�5      ��  � �� 5      �� 5      " ��6&   .R�5      � $ RootElement��6    5        5   "   CommonStates��. 5   &     
Normal��62     5   &   	MouseOver��. 5   *   �� .��5   .   �� $	 MouseOverBorder��6K   $2
 ,(Border.BorderBrush).(SolidColorBrush.Color)�6s   .g�5   2   �� $ 0��6F   $ 	#FF99C1E2��6R   5   /   5   +   5   '     5   &   Disabled��. 5   *   �� .��5   .   U� $	 DisabledVisualElement��6L   $
 Opacity�6z   .\�5   2   �� $ 0��6G   $ 1Q�6S   5   /   5   +   5   '     5    &   ReadOnly��. 5!   *   �� .��5"   .   U� $	 ReadOnlyVisualElement��6L   $
 Opacity�6z   .\�5#   2   �� $ 0��6G   $ 1Q�6S   5$   /   5%   +   5&   '   5'   #     5(   "   FocusStates��. 5)   &     Focused��. 5*   *   �� .��5+   .   U� $	 FocusVisualElement��6L   $
 Opacity�6w   .\�5,   2   �� $ 0��6G   $ 1Q�6S   5-   /   5.   +   5/   '     50   &   	Unfocused��. 51   *   �� .��52   .   U� $	 FocusVisualElement��6L   $
 Opacity�6w   .\�53   2   �� $ 0��6G   $ 0Q�6S   54   /   55   +   56   '   57   #     58   "   ValidationStates��. 59   &     	Valid��62     5:   &   InvalidUnfocused��. 5<   *   �� 5=   +   5>   '     5?   &   InvalidFocused��. 5A   *   �� 5B   +   5C   '   5D   #   .+�5F      �� $ Border��6%   #��z��65   #��z��6_   #��z��6�   $ 1��6�   ._�5G   "   � .+�5I   &   �� $ ReadOnlyVisualElement��6-   $ 0Q�6L   
�������6X   �� 5K   &   $ MouseOverBorder��6-   
������ $��0q�6`   ._�5M   *   �� $ PART_ContentHost��67   $��0q�6Q   ��.  #��z��6w   5N   '   5O   #   5P      �� 5Q      $ DisabledVisualElement��6%    .  $ 0Q�6]   ���	#A5F7F7F7���	#A5F7F7F7#��z��6�   �� 5S      $ FocusVisualElement��6%   $��1q�6A    .  $ 0Q�6e   ���	#FF6DBDD1$��0q�6�   5T      5U      5W      5X      �� 5Z   
   .R�5[      �� $ ��Resources/Browse_16x16.png��6   5\      5]      .��5_      �  � RowDefinitions 5`   
   �� 5a      6   �� 5b      6    � ColumnDefinitions 5d   
   �� 5e      $��* �6   �� 5f      $
��0.1* �6   .+�5i   
   � $��0��6   $��1��6    5j      �� 5k      $��* �6#   �� 5l      $
��0.1* �6#   �� 5m      $��* �6#    5o      �� 5p      $��* �6    �� 5q      $
��0.1* �6    �� 5r      $��* �6    .+�5u      �� -   5         ��Name$ FirstChannelSelect��5u      $��1��61   $��1��6A   {�. $y�Visible=�5v   5   ��5u   N   �� *LoadFirstPopupCommand+��5w   $   ��  �� Source# [ .��5y      6   0NationalInstruments.VeriStand.Shell.ChannelPopup  -   5          Name$ FirstUiSdfPopup��5y   %   $��Bottom=�6>   ^	 ZNationalInstruments.ConfigurationUI, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null9 	 3NationalInstruments.CBSCommon.Controls.PopupAdorner   	Placement$ BelowCenter=�5z   $      IsOpen .     PlacementTarget 5y   V   ��  �� ElementName$ FirstChannelSelect��5z   <   5{      5|      � 5}   
   $��1��6   $��1��6    5~      �� 5      $��* �6#   �� 5�      $
��0.1* �6#   �� 5�      $��* �6#    5�      �� 5�      $��* �6    �� 5�      $
��0.1* �6    �� 5�      $��* �6    .+�5�      �� -   5        $ SecondChannelSelect��5�      $��1��62   $��1��6B   {�. $y�Visible=�5�   5   ��5�   O   �� *LoadSecondPopupCommand+��5�   $   �� # [ .��5�        -   5        $ SecondUiSdfPopup��5�   %   $��Bottom=�6?   $ BelowCenter=�5�   $    .   5�   W   �� $ SecondChannelSelect��5�   <   5�      5�      �� 5�   
   $��0��6   $��0��6%   $��1q�62    �� Orientation$ 
Horizontal=�6=   .+�5�      0  *NationalInstruments.Controls.StringControl  -   5          Name$ FirstTextControl��5�       #���   6;   $��90��5�       $��20��6.   $	��100��5�      $
��Auto��6+   $��60��69   $��2q�6H   $��2q�6S   $��10(�5�       " �� VerticalScrollBarVisibility$
 Auto=�6.     �� TextWrapping$
  Wrap=�5�      !   SelectOnFocus! . $��1q�6H   5�      �� 5�   
   $��0��6   $��1��6%   $��1q�62   $ 
Horizontal=�6=   .+�5�        -   5        $ SecondTextControl��5�       #���   6<   $��90��5�       $��20��6.   $	��100��5�      $
��Auto��6+   $��60��69   $��2q�6H   $��2q�6S   $��10(�5�       $
 Auto=�6.   $
  Wrap=�5�      ! . $��1q�6H   5�      5�      5�      