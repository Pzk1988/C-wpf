   M S B A M L   `   `   `  ����L  HEL400Analyzer_v02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:EL400Analyzer_v02.ResourceDictionaries&EL400Analyzer_v02.ResourceDictionaries  5      K*clr-namespace:EL400Analyzer_v02.ConvertersEL400Analyzer_v02.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0892    ,EL400Analyzer_v02.Converters.ByteToHexString   byteToHexString  virtualStateTemplate  �� Orientation �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Value  inputCardTemplate �� 	Converter �� Triggers	 �� RelativeSource
 �� 
TargetName  CabinetLogTemplate�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      >local4clr-namespace:EL400Analyzer_v02.ResourceDictionaries  5      3conv*clr-namespace:EL400Analyzer_v02.Converters  5      %<  &	        &	      &	 �    7   &	      7  7  7  7     5      6   �� 5      .R�5	   
   �� $  
Horizontal=�6   .+�5
      �� ��6   �� *ID+��5      �� 5      " ��6    .�5      ��  � ��
 �   �6;    5      �� 5   "    6.   �� *State+ True6H   .a�5   &   ��  � ��
 � � �6C   5   #   �� 5   "    6.   �� *OCC+ True6F   .a�5   &   ��  � ��
 �  ��6C   5   #   5      5      �� 5      $�� ��6   5      5      �� 5      .R�5   
   �� $  
Horizontal=�6   .+�5      �� $
��dash��6   $��-��6$   �� 5       ��6   �� 8   5!       5"   
   �� 5#       6   �� 	 �� *PreviousData+ 6[   Z� .a�5$      �� $

 dash��6    � y�$ 	Collapsed=�6A   5%      5'      �� 5)      .R�5*   
   �� $  
Horizontal=�6   .+�5,      �� ��6   �� *	CabinetID+�� 5-      $	��,  ��6   �� 5/      8��  ��6   �� *
InputCards+��50      �� 51      .R�52      �� $  
Horizontal=�6%   53      55      �� 57      $	��   ��6   �� 59      8�� ��6   �� *OutputCards+��5:      �� 5;      .R�5<      �� $  
Horizontal=�6%   5=      5?      �� 5A      $	��   ��6   �� 5C      8�� ��6   �� *VirtualInputs+��5D      �� 5E      .R�5F      �� $  
Horizontal=�6%   5G      5I      �� 5K      $	��   ��6   �� 5M      8�� ��6   �� *VirtualOutputs+��5N      �� 5O      .R�5P      �� $  
Horizontal=�6%   5Q      5S      5T      5U      5V      