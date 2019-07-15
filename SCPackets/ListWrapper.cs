using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;

namespace SCPackets
{
    public class ListWrapper<TObj>
    {
        private readonly List<TObj> _list;

        public ListWrapper()
        {
            _list = new List<TObj>();
        }

        #region Implementation
        public IReadOnlyCollection<TObj> GetList()
        {
            return _list.AsReadOnly();
        }

        public void Add(TObj obj, bool onlyOneInstance = true)
        {
            if (onlyOneInstance)
                if (_list.Contains(obj)) return;

            _list.Add(obj);
            OnAfterAdd(new AfterAddEventArgs<TObj>(obj));
        }
        public void AddRange(List<TObj> obj)
        {
            _list.AddRange(obj);

            foreach (var item in obj)
                OnAfterAdd(new AfterAddEventArgs<TObj>(item));
        }
        public void Remove(TObj obj)
        {
            _list.Remove(obj);
            OnAfterRemove(new AfterRemoveEventArgs<TObj>(obj));
        }
        #endregion Implementation

        #region Events
        public event EventHandler<AfterAddEventArgs<TObj>> AfterAdd;
        protected virtual void OnAfterAdd(AfterAddEventArgs<TObj> e)
        {
            var handler = AfterAdd;
            handler?.Invoke(this, e);
        }

        public event EventHandler<AfterRemoveEventArgs<TObj>> AfterRemove;
        protected virtual void OnAfterRemove(AfterRemoveEventArgs<TObj> e)
        {
            var handler = AfterRemove;
            handler?.Invoke(this, e);
        }

        public class AfterAddEventArgs<TEventArgObj> : AddingNewEventArgs
        {
            public AfterAddEventArgs(TEventArgObj item)
            {
                Item = item;
            }

            public TEventArgObj Item { get; private set; }
        }

        public class AfterRemoveEventArgs<TEventArgObj> : AddingNewEventArgs
        {
            public AfterRemoveEventArgs(TEventArgObj item)
            {
                Item = item;
            }

            public TEventArgObj Item { get; private set; }
        }

        #endregion Events
    }
}
