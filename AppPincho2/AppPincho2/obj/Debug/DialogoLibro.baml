   M S B A M L   `   `   `  ????E  AAppPincho2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppPincho2
AppPincho2  5   	       AppPincho2.DialogoLibro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppPincho2     5   	     ? Title$  DialogoLibro??5   	   $	??311??6   $	??264??6+   .??5	      ? .+?5
   
   ?? $??Titulo:??6   $
??Left=?6"   $??	23,30,0,0q?6=   $	??Top=?6P   ?? 5   
   $??Autor:??6   $
??Left=?6!   $??	23,91,0,0q?6<   $	??Top=?6O   ?? 5   
   $??Fecha:??6   $
??Left=?6!   $??
23,153,0,0q?6<   $	??Top=?6P   ?? 5   
   -   5         ??Name$ tbNombre??5      $
??Left=?6&   $??	89,38,0,0q?6A    ?? TextWrapping$
 Wrap=?6T   $	??Top=?6?   $	??145??6?   ??6?   ??  ?? Path$ Titulo? ?? NotifyOnValidationError .  ?? ValidatesOnDataErrors . 6?   ?? 5   
   -   5        $ tbAutor??5      $
??Left=?6#   $??	89,95,0,0q?6>   $
 Wrap=?6Q   $	??Top=?6?   $	??145??6?   ??6?   ?? $ Autor? .  . 6?   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFecha??5      $
??Left=?6'   $??
89,153,0,0q?6B   $	??Top=?6V      SelectedDate 6n   ?? $ Fecha??? 5   
   -   5         ??Name$ 
btCancelar??5      $??Cancelar??6&   $
??Left=?69   $??137,230,0,0q?6T   $	??Top=?6i   $??26??6?   $??97??6?   6?   ?? 5   
   -   5        $ 	btAceptar??5      $??Aceptar??6%   $
??Left=?67   $??
23,230,0,0q?6R   $	??Top=?6f   $??26??6~   $??96??6?   6?   5      5      