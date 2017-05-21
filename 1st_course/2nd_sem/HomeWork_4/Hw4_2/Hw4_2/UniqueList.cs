namespace Hw42
{
    public class UniqueList : List
    {
        /// <summary>
        /// Добавляет новое значение, если его нет в списке, если же есть, то бросает исключение
        /// </summary>
        /// <param name="value">Новое значение</param>
        /// <param name="position">Позиция, на которую нужно поставить новое значение</param>
        public override void AddValueToPosition(int value, int position)
        {
            if (IsContainedElementInList(value))
            {
                throw new AddException("Данный элемент уже есть в списке!");
            }
            else
            {
                base.AddValueToPosition(value, position);
            }
        }

        /// <summary>
        /// Удаляет элемент из списка, если его нет то бросает исключение
        /// </summary>
        /// <param name="value">Элемент, который нужно удалить</param>
        public void DeleteElementFromUniqueList(int value)
        {
            if (!IsContainedElementInList(value))
            {
                throw new DeleteException("Такого элемента нет в списке!");
            }
            else
            {
                DeleteElementFromList(value);
            }
        }
    }
}
