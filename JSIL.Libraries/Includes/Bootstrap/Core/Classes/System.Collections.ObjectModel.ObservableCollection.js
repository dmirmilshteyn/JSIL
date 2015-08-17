$jsilcore.$ObservableCollectionExternals = function ($) {
    var T = new JSIL.GenericParameter("T", "System.Collections.ObjectModel.ObservableCollection`1");
    $jsilcore.$ListExternals($, T, "ObservableCollection");

    var mscorlib = JSIL.GetCorlib();

    $.Method({ Static: false, Public: true, Virtual: true }, "add_CollectionChanged",
      JSIL.MethodSignature.Action(mscorlib.TypeRef("System.Collections.Specialized.NotifyCollectionChangedEventHandler")),
      function () { }
    );

    $.Method({ Static: false, Public: false, Virtual: true }, "add_PropertyChanged",
      JSIL.MethodSignature.Action(mscorlib.TypeRef("System.ComponentModel.PropertyChangedEventHandler")),
      function () { }
    );

    $.Method({ Static: false, Public: true, Virtual: true }, "remove_CollectionChanged",
      JSIL.MethodSignature.Action(mscorlib.TypeRef("System.Collections.Specialized.NotifyCollectionChangedEventHandler")),
      function () { }
    );

    $.Method({ Static: false, Public: false, Virtual: true }, "remove_PropertyChanged",
      JSIL.MethodSignature.Action(mscorlib.TypeRef("System.ComponentModel.PropertyChangedEventHandler")),
      function () { }
    );

    $.Method({ Static: false, Public: true }, ".ctor",
      new JSIL.MethodSignature(null, [mscorlib.TypeRef("System.Collections.Generic.List`1", [T])], []),
      function (list) {
          this._items = JSIL.EnumerableToArray(list, this.T);
          this._capacity = this._size = this._items.length;
      }
    );
};

JSIL.ImplementExternals("System.Collections.ObjectModel.ObservableCollection`1", $jsilcore.$ObservableCollectionExternals);