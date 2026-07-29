// ===== MOBILE NAVBAR FEATURES =====

document.addEventListener('DOMContentLoaded', function () {

    // Auto-close mobile menu on link click
    const navLinks = document.querySelectorAll('.navbar-nav .nav-link');
    const navbarToggler = document.querySelector('.navbar-toggler');
    const navbarCollapse = document.querySelector('.navbar-collapse');

    navLinks.forEach(link => {
        link.addEventListener('click', () => {
            if (navbarCollapse && navbarCollapse.classList.contains('show')) {
                navbarToggler.click();
            }
        });
    });

    // Toggle search bar
    const searchToggle = document.getElementById('searchToggle');
    const searchContainer = document.getElementById('searchContainer');
    const searchInput = document.getElementById('searchInput');
    const searchButton = document.getElementById('searchButton');

    if (searchToggle && searchContainer) {
        searchToggle.addEventListener('click', function () {
            // Close mobile menu if open
            if (navbarCollapse && navbarCollapse.classList.contains('show')) {
                navbarToggler.click();
            }
            // Toggle search
            searchContainer.classList.toggle('show');
            if (searchContainer.classList.contains('show')) {
                setTimeout(() => {
                    searchInput.focus();
                }, 300);
            }
        });
    }

    // Search functionality
    function performSearch() {
        const query = searchInput.value.trim().toLowerCase();
        if (query.length > 0) {
            // Redirect to search results or filter content
            window.location.href = `/search?q=${encodeURIComponent(query)}`;
        }
    }

    if (searchButton && searchInput) {
        searchButton.addEventListener('click', performSearch);
        searchInput.addEventListener('keypress', function (e) {
            if (e.key === 'Enter') {
                performSearch();
            }
        });
    }

    // Highlight current page in navigation
    const currentPath = window.location.pathname;
    document.querySelectorAll('.navbar-nav .nav-link').forEach(link => {
        const href = link.getAttribute('href');
        if (href && href !== '/' && currentPath.startsWith(href)) {
            link.classList.add('active');
        } else if (href === '/' && currentPath === '/') {
            link.classList.add('active');
        }
    });

    // Close search on outside click
    document.addEventListener('click', function (e) {
        if (searchContainer && searchContainer.classList.contains('show')) {
            const isSearchClick = searchContainer.contains(e.target) ||
                searchToggle.contains(e.target);
            if (!isSearchClick) {
                searchContainer.classList.remove('show');
            }
        }
    });

    // Back to top button
    const backToTopBtn = document.createElement('a');
    backToTopBtn.className = 'back-to-top';
    backToTopBtn.innerHTML = '<i class="fas fa-arrow-up"></i>';
    backToTopBtn.href = '#';
    backToTopBtn.setAttribute('aria-label', 'Back to top');
    document.body.appendChild(backToTopBtn);

    window.addEventListener('scroll', function () {
        if (window.scrollY > 300) {
            backToTopBtn.style.display = 'flex';
        } else {
            backToTopBtn.style.display = 'none';
        }
    });

    backToTopBtn.addEventListener('click', function (e) {
        e.preventDefault();
        window.scrollTo({ top: 0, behavior: 'smooth' });
    });
});

// ===== SCROLL EFFECT FOR NAVBAR =====
let lastScroll = 0;
window.addEventListener('scroll', function () {
    const navbar = document.querySelector('.navbar-custom');
    const currentScroll = window.pageYOffset || document.documentElement.scrollTop;

    if (currentScroll > 100) {
        navbar.style.boxShadow = '0 4px 30px rgba(0,0,0,0.4)';
        navbar.style.padding = '0.5rem 0';
    } else {
        navbar.style.boxShadow = '0 2px 20px rgba(0,0,0,0.3)';
        navbar.style.padding = '0.8rem 0';
    }

    lastScroll = currentScroll;
});

// ===== PROGRESS TRACKING =====
function saveProgress(page, completed) {
    const progress = JSON.parse(localStorage.getItem('lessonProgress') || '{}');
    progress[page] = completed;
    localStorage.setItem('lessonProgress', JSON.stringify(progress));
    updateProgressBar();
}

function getProgress(page) {
    const progress = JSON.parse(localStorage.getItem('lessonProgress') || '{}');
    return progress[page] || false;
}

function updateProgressBar() {
    const progressBar = document.querySelector('#fundamentalsProgress');
    if (!progressBar) return;

    const progress = JSON.parse(localStorage.getItem('lessonProgress') || '{}');
    const totalLessons = document.querySelectorAll('.lesson-card').length;
    const completedLessons = Object.values(progress).filter(v => v === true).length;
    const percentage = totalLessons > 0 ? Math.round((completedLessons / totalLessons) * 100) : 0;

    progressBar.style.width = percentage + '%';
    progressBar.textContent = percentage + '%';
}

// Initialize progress indicators
document.addEventListener('DOMContentLoaded', function () {
    updateProgressBar();

    document.querySelectorAll('.mark-complete').forEach(btn => {
        const page = btn.dataset.page;
        if (getProgress(page)) {
            btn.classList.add('completed');
            btn.textContent = '✓ Completed';
        }

        btn.addEventListener('click', function () {
            const page = this.dataset.page;
            const completed = !getProgress(page);
            saveProgress(page, completed);
            this.classList.toggle('completed');
            this.textContent = completed ? '✓ Completed' : 'Mark as Complete';
            updateProgressBar();
        });
    });
});