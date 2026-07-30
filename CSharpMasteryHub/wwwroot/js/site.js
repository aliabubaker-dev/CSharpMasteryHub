// ===== MOBILE NAVBAR FEATURES =====

document.addEventListener('DOMContentLoaded', function () {

    // ===== DROPDOWN FIX FOR MOBILE =====
    // Let Bootstrap handle dropdowns natively, just prevent navbar from closing
    const navbarToggler = document.querySelector('.navbar-toggler');
    const navbarCollapse = document.querySelector('.navbar-collapse');

    // Only close navbar when clicking on actual page links (not dropdown toggles)
    document.querySelectorAll('.navbar-nav .nav-link').forEach(link => {
        link.addEventListener('click', function (e) {
            // Check if this is a dropdown toggle
            const isDropdownToggle = this.classList.contains('dropdown-toggle') ||
                this.getAttribute('data-bs-toggle') === 'dropdown' ||
                this.getAttribute('data-bs-toggle') === 'dropdown' ||
                this.getAttribute('href') === '#';

            // Check if this is the search toggle
            const isSearchToggle = this.id === 'searchToggle';

            // Only close if it's NOT a dropdown toggle and NOT the search toggle
            if (!isDropdownToggle && !isSearchToggle) {
                if (navbarCollapse && navbarCollapse.classList.contains('show')) {
                    // Use Bootstrap's collapse hide method
                    const bsCollapse = bootstrap.Collapse.getInstance(navbarCollapse);
                    if (bsCollapse) {
                        bsCollapse.hide();
                    }
                }
            }
        });
    });

    // Fix for dropdown toggles on mobile - use Bootstrap's native behavior
    // Just ensure the navbar stays open when dropdown is toggled
    document.querySelectorAll('.dropdown-toggle').forEach(toggle => {
        toggle.addEventListener('click', function (e) {
            // Don't stop propagation - let Bootstrap handle it
            // Just prevent any custom interference
        });
    });

    // ===== SEARCH TOGGLE =====
    const searchToggle = document.getElementById('searchToggle');
    const searchContainer = document.getElementById('searchContainer');
    const searchInput = document.getElementById('searchInput');
    const searchButton = document.getElementById('searchButton');

    if (searchToggle && searchContainer) {
        searchToggle.addEventListener('click', function (e) {
            e.preventDefault();
            // Close mobile menu if open
            if (navbarCollapse && navbarCollapse.classList.contains('show')) {
                const bsCollapse = bootstrap.Collapse.getInstance(navbarCollapse);
                if (bsCollapse) {
                    bsCollapse.hide();
                }
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

    // ===== SEARCH FUNCTIONALITY =====
    function performSearch() {
        const query = searchInput.value.trim();
        if (query.length > 0) {
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

    // ===== HIGHLIGHT CURRENT PAGE =====
    const currentPath = window.location.pathname;
    document.querySelectorAll('.navbar-nav .nav-link').forEach(link => {
        // Skip dropdown toggles
        if (link.classList.contains('dropdown-toggle')) return;
        if (link.getAttribute('data-bs-toggle') === 'dropdown') return;
        if (link.id === 'searchToggle') return;

        const href = link.getAttribute('href');
        if (href && href !== '/' && currentPath.startsWith(href)) {
            link.classList.add('active');
        } else if (href === '/' && currentPath === '/') {
            link.classList.add('active');
        }
    });

    // ===== CLOSE SEARCH ON OUTSIDE CLICK =====
    document.addEventListener('click', function (e) {
        if (searchContainer && searchContainer.classList.contains('show')) {
            const isSearchClick = searchContainer.contains(e.target) ||
                searchToggle.contains(e.target);
            if (!isSearchClick) {
                searchContainer.classList.remove('show');
            }
        }
    });

    // ===== BACK TO TOP =====
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