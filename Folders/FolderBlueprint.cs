﻿namespace FileBuilder
{
    public class FolderBlueprint : Folders
    {

        #region =========== CONSTRUCTORS ======================
        public FolderBlueprint(string name) => ConstructorForFolder(name);
        #endregion --------------------------------------------
        

        #region =========== PUBLIC METHODS ====================
        public void MoveTo(Folders folder) => folder.Add(this);
        public void QuitFrom(Folders folder) => folder.Remove(this);
        #endregion --------------------------------------------

    }
}