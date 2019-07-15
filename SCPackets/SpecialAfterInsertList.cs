using System;
using System.ComponentModel;

namespace Server
{
    public class SpecialAfterInsertList<TRoom> : BindingList<TRoom>

    {
        protected override void InsertItem(int index, TRoom item)
        {
            base.InsertItem(index, item);
            OnAfterInsert(new AfterInsertEventArgs(index, item));
        }

        public event EventHandler<AfterInsertEventArgs> AfterInsert;
        protected virtual void OnAfterInsert(AfterInsertEventArgs e)
        {
            var handler = AfterInsert;
            handler?.Invoke(this, e);
        }

        public class AfterInsertEventArgs : AddingNewEventArgs
        {
            public AfterInsertEventArgs(int index, object item)
            {
                Index = index;
                Item = item;
            }

            public int Index { get; private set; }
            public object Item { get; private set; }
        }
    }
}
