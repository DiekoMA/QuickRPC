   M S B A M L   `   `   `  ????C  ?QuickRPC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuickRPC.PagesQuickRPC.Pages  5          QuickRPC.Pages.HomePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:QuickRPC.Pages     5      X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5        N? Title$  HomePage??5       ? ContextMenu 5      ?? 5   
   ??5      ?? 5      .R?5      ?? .+?5      ??  ?? Orientation$ 
Horizontal=?6%   .+?5      #  HandyControl.Controls.TextBox    Name$ Profile??6)   '  !HandyControl.Controls.InfoElement   Placeholder$
 Name??6:   m? 5      $
??Save??6'   5      m? 5      $??	Clear All??6#   m? 5      $
??Copy??6#   m? 5      $??Paste??6#   5      5      5      .??5      )  #HandyControl.Controls.RelativePanel  $??Stretch=?6   $??Stretch=?63   .+?5    
   ?? $??	0,123,0,0q?6   $ 
Horizontal=?6(   .+?5!      ?? $ Vertical=?6   $??Stretch=?60   .+?5"        -   5        $ ClientIdBox??5"         	Necessary$
 True??62   (  "HandyControl.Controls.TitleElement   Title$ 	Client ID??6R   $ 80351110224678912??6t   $??5,0,5,0q?6?   $??Center=?6?   $??Center=?6?    ?? TextWrapping$
 Wrap=?6?   $?? ??6   $	??335??6    5#      -   5        $ 
DetailsBox??5#      $ Details??61   $ My Awesome Rich Presence??6Q   $??5,0,5,0q?6?   $??Center=?6?   $??Center=?6?   $
 Wrap=?6?   $?? ??6?   $	??335??6?     5$      -   5        $ StateBox??5$      $ State??6/   $ Playing QuickRPC??6M   $??5,0,5,0q?6{   $??Center=?6?   $??Center=?6?   $
 Wrap=?6?   $?? ??6?   $	??335??6?   	? 5%      -   5         	?Name$ NoneTimeStampRb??5%      $??5,5,5,5q?67   $
??None??6H   $
??Left=?6W   	? 5&      -   5        $ TimeStampRb??5&      $??5,5,5,5q?63   $??	Timestamp??6D   $
??Left=?6X   	? 5'      -   5        $ CustomTimeStampRb??5'      $??5,5,5,5q?69   $??Custom??6J   $
??Left=?6[   6v   ?? 5(      $ 
Horizontal=?6   .+?5)      )  #HandyControl.Controls.NumericUpDown  -   5        	  Name$	 PartySizeBox??5)   '   
   TitlePlacement$

 Left=?6=   $ 
Party Size??6c   $??Center=?6?   $??Center=?6?      NumericUpDownExtend#??[  6?   $??5,0,5,0q?6?     5*      -   5        $	 MaxPartySizeBox??5*   '   $

 Left=?6@   $ Max Size??6f   $??Center=?6?   $??Center=?6?   #??[  6?   $??5,0,5,0q?6?   5+      5,      ?? 5-      $	??454??6   $ 
Horizontal=?6%   $??Stretch=?6>   $??Stretch=?6Z   .+?5.      ?? $ Vertical=?6   $	??455??64   .+?5/      ?? $ 
Horizontal=?6!   .+?50        -	   5        $ LargeKey??50   %   $ Large Image Key??67   $	??200??6^   $??5,0,5,0q?6j   $
??Left=?6{     51      -
   5        $ SmallKey??51   %   $ Small Image Key??67   $	??200??6^   $??5,0,5,0q?6j   $
??Left=?6{   52      ?? 53      $ 
Horizontal=?6!   .+?54        -   5        $ 	LargeText??54   %   $ Large Image Text??68   $	??200??6`   $??5,0,5,0q?6l   $
??Left=?6}     55      -   5        $ 	SmallText??55   %   $ Small Image Text??68   $	??200??6`   $??5,0,5,0q?6l   $
??Left=?6}   56      ?? 57      $ 
Horizontal=?6!   .+?58        -   5        $ Button1Text??58   %   $ Button 1 Text??6:   $	??200??6_   $??5,0,5,0q?6k   $
??Left=?6|     59      -   5        $ Button2Text??59   %   $ Button 2 Text??6:   $	??200??6_   $??5,0,5,0q?6k   $
??Left=?6|   5:      ?? 5;      $ 
Horizontal=?6!   .+?5<        -   5        $ 
Button1Url??5<   %   $ Button 1 URL??69   $	??200??6]   $??5,0,5,0q?6i   $
??Left=?6z     5=      -   5        $ 
Button2Url??5=   %   $ Button 2 URL??69   $	??200??6]   $??5,0,5,0q?6i   $
??Left=?6z   5>      5?      5@      5A      o? 5B   
   $??0,0,314,373q?6   $	??120??6$   .@?5C      m? -   5         m?Name$ StartMenuItem??5C      $??Start??6.   6=   m? 5D      -   5        $ PauseMenuItem??5D      $??Pause??6.   6=   m? 5E      -   5        $ StopMenuItem??5E      $
??Stop??6-   6;   m? 5F      -   5        $ RestartMenuItem??5F      $??Restart??60   6A   m? 5G      -   5        $ SaveMenuItem??5G      $
??Save??6-   6;   m? 5H      -   5        $ ClearMenuItem??5H      $??Clear??6.     5I      -   5        $ ProfileNameBox??5I      $?? ??61   $ 	Profile 1??69   $ Profile Name??6`   $

 Left=?6?   5J      ?? 5K   
   -   5         ??Name$ UserInfoPanel??5K      $??160,10,179,323q?6,   $ Vertical=?6D   5M      5N      5O      