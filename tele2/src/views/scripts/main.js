(() => {
  const buttons = document.querySelectorAll("[data-selected-page]");
  const pages = document.querySelectorAll("[data-page]");

  const setCurrentPage = (pageName) => {
    pages.forEach((page) => {
      if (page.dataset.page === pageName) {
        page.style.display = "block";
      } else {
        page.style.display = "none";
      }
    });
  };

  const resetButtons = () => {
    buttons.forEach((button) => {
      button.removeAttribute("data-selected-button");
    });
  };

  buttons.forEach((button) => {
    button.addEventListener("click", ({ target }) => {
      resetButtons();
      target.setAttribute("data-selected-button", "");
      setCurrentPage(target.dataset.selectedPage);
    });
  });
})();
