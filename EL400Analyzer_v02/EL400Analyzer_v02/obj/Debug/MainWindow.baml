   M S B A M L   `   `   `  ����L  HEL400Analyzer_v02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EL400Analyzer_v02EL400Analyzer_v02  5   	   I)clr-namespace:EL400Analyzer_v02.SelectorsEL400Analyzer_v02.Selectors  5   	   "    EL400Analyzer_v02.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:EL400Analyzer_v02     5   	   :conv)clr-namespace:EL400Analyzer_v02.Selectors     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��725��6)    � 	Resources 5
      4  .EL400Analyzer_v02.Selectors.LogTempletSelector   logTempletSelector��%   &	          5   
   6"   5      .��5      � .+�5   
   �� -   5        $��ListViewForLogs��5      
���   ���6*   ��  �� View 5      �� 5      .P�5      �� $
��Date��6%    �� Width$
 Auto��63    �� DisplayMemberBinding 6@   �� *Date+�� 5      $
��Type��6%   $
 Auto��63    6@   �� *Type+�� 5      $
��Data��6%   $
 Auto��63    �� CellTemplateSelector# [  6@   5      5      5      5      